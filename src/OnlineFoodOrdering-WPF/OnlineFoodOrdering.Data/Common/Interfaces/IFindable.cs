using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Data.Common.Interfaces
{
    public interface IFindable<T> where T : class
    {
        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);

        public Task<T> FindAsync(long id);
    }
}
