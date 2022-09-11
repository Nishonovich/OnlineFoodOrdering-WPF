using OnlineFoodOrdering.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public Task<T> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(long id, T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<T>> WhereAsync(Expression<Func<T, bool>>? predicate = null)
        {
            throw new NotImplementedException();
        }
    }
}
