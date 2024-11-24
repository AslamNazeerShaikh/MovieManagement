using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieManagement.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public Task<T?> GetByIdAsync(int id);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task AddAsync(T entity);
        public void Update(T entity);
        public void Remove(T entity);
    }
}
