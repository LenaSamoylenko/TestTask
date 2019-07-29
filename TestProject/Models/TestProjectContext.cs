using Microsoft.EntityFrameworkCore;
using TestProject.Models;

namespace TestProject
{
    public class TestProjectContext : DbContext
    {
        public TestProjectContext(DbContextOptions<TestProjectContext> options) : base(options)
        { }


        public DbSet<IStoreable> Entities { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder
        //        .UseLazyLoadingProxies();
        //}


    }
}
