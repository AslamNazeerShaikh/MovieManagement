using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManagement.Core.Entities;

namespace MovieManagement.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        public IActorRepository Actors { get; }
        public IMovieRepository Movies { get; }
        public IGenreRepository Genres { get; }
        public Task<int> SaveChangesAsync();
    }
}
