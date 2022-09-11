using OnlineFoodOrdering.Data.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrdering.Data.Interfaces
{
    public interface IGenericRepository<T>
        : ICreateable<T>, IUpdateable<T>, IDeleteable<T>, IFindable<T>, ISearchable<T> where T : class
    {

    }
}
