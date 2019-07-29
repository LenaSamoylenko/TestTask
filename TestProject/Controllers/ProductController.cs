using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using TestProject.Models;

namespace TestProject.Controllers
{
    public class ProductController : Controller, IRepository<Product>
    {
        #region fields
        private IRepository<Product> _repository;
        #endregion

        #region Constructors
        public ProductController(IRepository<Product> repository)
        {
            _repository = repository;
        }
        #endregion

        public IEnumerable<Product> All()
        {
            return _repository.All();
        }

        public void Delete(IComparable id)
        {
            _repository.Delete(id);
        }

        public Product FindById(IComparable id)
        {
            return _repository.FindById(id);
        }

        public void Save(Product item)
        {
            _repository.Save(item);
        }
    }
}
