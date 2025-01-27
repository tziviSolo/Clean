using Clean.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repositories
{
    public class EntityRepository<T>(DataContext dataContext) : IEntityRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet = dataContext.Set<T>();

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public T Update(int id, T entity)
        {
            var existEntity = _dbSet.Find(id);
            if (existEntity != null)
            {
                _dbSet.Entry(existEntity).CurrentValues.SetValues(entity);
            }
            return entity;
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
                _dbSet.Remove(entity);
        }
    }
}
