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

        // Get all entities from the database
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                var entities = await _dbSet.ToListAsync();

                if (entities == null || !entities.Any())
                {
                    // Return an empty collection if no records found
                    return Enumerable.Empty<T>();
                }

                return entities;
            }
            catch (Exception ex)
            {
                // Log exception
                throw new Exception("An error occurred while retrieving all entities", ex);
            }
        }

        // Get entity by Id
        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Invalid ID");
                }

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
            catch (Exception ex)
            {
                // Log exception
                throw new Exception($"An error occurred while retrieving the entity with ID {id}", ex);
            }
        }

        // Add a new entity
        public async Task AddAsync(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
                }

                // Add the new entity to the context
                await _dbSet.AddAsync(entity);
            }
            catch (ArgumentNullException ex)
            {
                // Log specific error for null entity
                throw new ArgumentNullException("Entity cannot be null", ex);
            }
            catch (InvalidOperationException ex)
            {
                // Log the exception or handle it as per your requirement
                throw new InvalidOperationException("An error occurred while adding the entity.", ex);
            }
            catch (Exception ex)
            {
                // Log general exception
                throw new Exception("An error occurred while adding the entity", ex);
            }
        }

        // Add a range of entities
        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null || !entities.Any())
                {
                    throw new ArgumentNullException(nameof(entities), "Entities collection cannot be null or empty");
                }

                await _dbSet.AddRangeAsync(entities);
            }
            catch (ArgumentNullException ex)
            {
                // Log specific error for null entities
                throw new ArgumentNullException("Entities collection cannot be null or empty", ex);
            }
            catch (Exception ex)
            {
                // Log general exception
                throw new Exception("An error occurred while adding the range of entities", ex);
            }
        }

        // Update an existing entity
        public async Task UpdateAsync(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
                }

                _dbSet.Update(entity);      // Mark the entity as modified
                await Task.CompletedTask;   //No actual DB call, just update tracking.
            }
            catch (ArgumentNullException ex)
            {
                // Log specific error for null entity
                throw new ArgumentNullException("Entity cannot be null", ex);
            }
            catch (Exception ex)
            {
                // Handle concurrency issues here
                throw new InvalidOperationException("The entity was updated by another user.", ex);
            }
        }

        // Delete an entity
        public async Task DeleteAsync(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
                }

                _dbSet.Remove(entity);
                await Task.CompletedTask;   // No actual DB call, just delete tracking
            }
            catch (ArgumentNullException ex)
            {
                // Log specific error for null entity
                throw new ArgumentNullException("Entity cannot be null", ex);
            }
            catch (Exception ex)
            {
                // Log general exception
                throw new Exception("An error occurred while deleting the entity", ex);
            }
        }

        // Delete a range of entities
        public async Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null || !entities.Any())
                {
                    throw new ArgumentNullException(nameof(entities), "Entities collection cannot be null or empty");
                }

                _dbSet.RemoveRange(entities);
                await Task.CompletedTask;       // No actual DB call, just delete tracking
            }
            catch (ArgumentNullException ex)
            {
                // Log specific error for null entities
                throw new ArgumentNullException("Entities collection cannot be null or empty", ex);
            }
            catch (Exception ex)
            {
                // Log general exception
                throw new Exception("An error occurred while deleting the range of entities", ex);
            }
        }

        // Find entities based on a predicate
        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                if (predicate == null)
                {
                    throw new ArgumentNullException(nameof(predicate), "Predicate cannot be null");
                }

                var entities = await _dbSet.Where(predicate).ToListAsync();
                if (entities == null || !entities.Any())
                {
                    return Enumerable.Empty<T>();  // Return an empty collection if no records found
                }

                return entities;
            }
            catch (ArgumentNullException ex)
            {
                // Log specific error for null predicate
                throw new ArgumentNullException("Predicate cannot be null", ex);
            }
            catch (Exception ex)
            {
                // Log general exception
                throw new Exception("An error occurred while finding the entities", ex);
            }
        }
    }
}
