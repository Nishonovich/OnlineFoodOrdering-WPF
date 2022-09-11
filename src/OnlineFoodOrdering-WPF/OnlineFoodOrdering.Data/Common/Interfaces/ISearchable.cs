using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Data.Common.Interfaces
{
    public interface ISearchable<T> where T : class
    {
        public Task<IQueryable<T>> WhereAsync(Expression<Func<T, bool>> predicate);
    }
}
