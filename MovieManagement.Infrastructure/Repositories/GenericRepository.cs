using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Application.Interfaces;
using MovieManagement.Infrastructure.Context;

namespace MovieManagement.Infrastructure.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly AppDbContext _dbContext;

    public GenericRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        // Use FindAsync to asynchronously search for an entity by its ID
        var entity = await _dbContext.Set<T>().FindAsync(id);

        if (entity == null)
        {
            // You can add custom logic here if you'd like, for example:
            // Log information, return a default value, throw an exception, etc.
            // For now, we'll just return null to indicate the entity wasn't found.
            // You can throw a custom exception if the entity is not found
        }

        return entity; // Can be null if not found.
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync(); // ToListAsync for async operation
    }

    public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        return await _dbContext.Set<T>().Where(predicate).ToListAsync(); // Using Where and ToListAsync for async
    }

    public async Task AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity); // AddAsync for async entity addition
    }

    public async Task AddRangeAsync(IEnumerable<T> entities)
    {
        await _dbContext.Set<T>().AddRangeAsync(entities); // AddRangeAsync for async bulk entity addition
    }

    public void Remove(T entity)
    {
        _dbContext.Set<T>().Remove(entity); // Remove does not need to be async, as it's a local operation
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _dbContext.Set<T>().RemoveRange(entities); // RemoveRange does not need to be async
    }
}