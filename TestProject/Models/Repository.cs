using TestProject;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TestProject
{

    public class Repository<T> : IRepository<T> where T : class, IStoreable
    {
        private readonly TestProjectContext _dbContext;

        public Repository(TestProjectContext context)
        {
            _dbContext = context;
        }

        public IEnumerable<T> All()
        {
            return _dbContext.Set<T>();
        }

        public void Delete(IComparable id)
        {
            var entity = FindById(id);
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public T FindById(IComparable id)
        {
            return _dbContext.Set<T>()
                .Find(id);
        }

        public void Save(T item)
        {
            _dbContext.Add(item);
            _dbContext.SaveChanges();
        }

        private async Task<T> GetById(IComparable id)
        {
            return await _dbContext.Set<T>()
                        .FirstOrDefaultAsync(e => e.Id == id);
        }
    }

}
