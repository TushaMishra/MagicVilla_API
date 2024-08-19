using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MagicT_TAPI.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, String? includeProperties = null,
            int pageSize = 3, int pageNumber = 1);
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true, String? includeProperties = null);
        Task CreateAsync(T entity);
        Task RemoveAsync(T entity);
        Task SaveAsync();
    }
}
