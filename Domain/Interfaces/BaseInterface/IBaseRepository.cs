using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Domain.Interfaces.BaseInterface
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Create(T objeto);
        Task<T> Update(T objeto);
        Task<T> GetById(Guid Id);
        Task<List<T>> GetList(Expression<Func<T, bool>> expression = null,
                           Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    }
}
