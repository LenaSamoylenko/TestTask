using System;
using System.Collections.Generic;
using Moq;
using TestProject;
using TestProject.Models;
using TestProject.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject
{
    [TestClass]
    public class ProductControllerTest
    {
     
        [TestMethod]
        public void Check_Count_Of_Returned_Products_AllMethod()
        {
            //Arrange
            var mock = new Mock<IRepository<Product>>();
            mock.Setup(r => r.All()).Returns(new List<Product>() {
                new Product() {Id=1},
                new Product() {Id=2},
                new Product() {Id=3}
            });
            ProductController controller = new ProductController(mock.Object);
            int expected = 3;

            //Act
            var result = controller.All();

            var count = 0;
            foreach (var item in result)
            {
                count++;
            }

            //Assert
            Assert.AreEqual(expected, count);
        }

        [TestMethod]
        public void Find_By_ID()
        {
            //Arrange
            var mock = new Mock<IRepository<Product>>();
            IComparable IDForSearch = 2;

            mock.Setup(r => r.FindById(IDForSearch)).Returns(
                new Product() {Id=2});

            ProductController controller = new ProductController(mock.Object);
            

            //Act
            var result = controller.FindById(IDForSearch);

            //Assert
            Assert.AreEqual(IDForSearch, result.Id);

        }
    }
}


