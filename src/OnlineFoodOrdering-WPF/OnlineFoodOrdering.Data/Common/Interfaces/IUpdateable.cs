using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Data.Common.Interfaces
{
    public interface IUpdateable<T> where T : class
    {
        public Task<T> UpdateAsync(long id, T entity);
    }

}
