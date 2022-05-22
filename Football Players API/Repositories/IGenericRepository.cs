using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Football_Players_API.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);

        Task<IReadOnlyList<T>> GetAllAsync();

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(Guid id);
    }
}
