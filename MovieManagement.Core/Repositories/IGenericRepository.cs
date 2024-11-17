using System.Linq.Expressions;

namespace MovieManagement.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public Task AddAsync(T entity);
        public Task AddRangeAsync(IEnumerable<T> entities);
        public Task UpdateAsync(T entity);
        public Task DeleteAsync(T entity);
        public Task DeleteRangeAsync(IEnumerable<T> entities);
        public Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
    }
}
