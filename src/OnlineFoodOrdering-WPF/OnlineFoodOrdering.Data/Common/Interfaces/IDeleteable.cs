using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Data.Common.Interfaces
{
    public interface IDeleteable<T> where T : class
    {
        public Task<T> DeleteAsync(long id);
    }

}
