using System;
using Domain.Common;
using Microsoft.EntityFrameworkCore;


namespace Application.Repositories.Abstraction
{
    public interface IGenericRepository<T> where T : class 
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(IEnumerable<T> entities);
        bool Delete(T item);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetById(int id);
        bool Update(T entity);
    }
}

