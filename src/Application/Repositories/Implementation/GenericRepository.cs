using System;
using Application.Repositories.Abstraction;
using Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories.Implementation
{
    public class GenericRepository<T, U> : IGenericRepository<T, U> where T : BaseEntity where U : DbContext
    {
        private readonly U _context;
        public GenericRepository(U context)
        {
            _context = context;

        }
        public async Task<T> AddAsync(T entity)
        {
            _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
            //todo add if else statement
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            //todo add if else statement
        }

        public async Task<T> Get(Guid id)
        {
            var result = await _context.Set<T>().FindAsync(id);
            return result;
           
            //todo add if else statement
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await _context.Set<T>().ToListAsync();
            return result;
            //todo add if else statement
        }
    }
}

