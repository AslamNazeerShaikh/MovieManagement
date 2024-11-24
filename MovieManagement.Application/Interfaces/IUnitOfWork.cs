using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieManagement.Domain.Entities;

namespace MovieManagement.Application.Interfaces
{
    public interface IUnitOfWork
    {
        public IRepository<Teacher> Teachers { get; }
        public IRepository<Student> Students { get; }
        public IRepository<Subject> Subjects { get; }
        public Task<int> SaveChangesAsync();
    }
}
