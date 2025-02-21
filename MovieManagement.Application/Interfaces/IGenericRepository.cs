using System.Linq.Expressions;

namespace MovieManagement.Application.Interfaces;

public interface IGenericRepository<T> where T : class
{
    public Task<T?> GetByIdAsync(int id);                                        // Async version of GetById
    public Task<IEnumerable<T>> GetAllAsync();                                  // Async version of GetAll
    public Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate); // Async version of Find
    public Task AddAsync(T entity);                                             // Async version of Add
    public Task AddRangeAsync(IEnumerable<T> entities);                         // Async version of AddRange
    public void Remove(T entity);                                          // Async version of Remove
    public void RemoveRange(IEnumerable<T> entities);                      // Async version of RemoveRange
}