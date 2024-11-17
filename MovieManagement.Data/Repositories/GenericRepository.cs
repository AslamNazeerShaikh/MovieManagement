using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Core.Exceptions;
using MovieManagement.Core.Repositories;
using MovieManagement.Data.Context;

namespace MovieManagement.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

        public async Task<T> GetByIdAsync(int id)
        {
            if (_dbSet == null)
            {
                // Handle the situation where DbSet is null.
                throw new InvalidOperationException("The DbSet is not initialized.");
            }

            var entity = await _dbSet.FindAsync(id);

            if (entity == null)
            {
                // Throw custom exception when entity is not found
                throw new EntityNotFoundException($"Entity of type {typeof(T).Name} with ID {id} not found.");
            }

            return entity;
        }

        public async Task AddAsync(T entity)
        {
            try
            {
                // Add the new entity to the context
                await _dbSet.AddAsync(entity);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as per your requirement
                throw new InvalidOperationException("An error occurred while adding the entity.", ex);
            }
        }

        public Task UpdateAsync(T entity)
        {
            try
            {
                // Mark the entity as modified
                _dbSet.Update(entity);
            }
            catch (Exception ex)
            {
                // Handle concurrency issues here
                throw new InvalidOperationException("The entity was updated by another user.", ex);
            }

            return Task.CompletedTask;
        }

        public Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public Task AddRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
