using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        public T GetById(int id);
        public IEnumerable<T> GetAll();
        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        public void Add(T entity);
        public void AddRange(IEnumerable<T> entities);
        public void Remove(T entity);
        public void RemoveRange(IEnumerable<T> entities);
    }
}
