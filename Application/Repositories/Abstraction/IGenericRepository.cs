using System;
using Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories.Abstraction
{
    public interface IGenericRepository<T, U> where T : BaseEntity where U : DbContext
    {
        Task<T> AddAsync(T entity);
        void Delete(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> Get(Guid id);
        
    }
}

