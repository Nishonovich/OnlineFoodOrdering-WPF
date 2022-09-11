using OnlineFoodOrdering.Data.Common.Interfaces;

namespace OnlineFoodOrdering.Data.Interfaces
{
    public interface IGenericRepository<T>
        : ICreateable<T>, IUpdateable<T>, IDeleteable<T>, IFindable<T>, ISearchable<T> where T : class
    {

    }
}
