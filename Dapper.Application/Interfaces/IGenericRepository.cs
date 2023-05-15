using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Dapper.Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<Guid> AddAsync(T entity);
        Task<Guid> UpdateAsync(T entity);
        Task<Guid> DeleteAsync(Guid id);

    }
}
