using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        private bool _disposed = false;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Actor = new ActorRepository(dbContext);
            Movie = new MovieRepository(dbContext);
            Genre = new GenreRepository(dbContext);
            Biography = new BiographyRepository(dbContext);
        }

        public IActorRepository Actor { get; set; }
        public IMovieRepository Movie { get; set; }
        public IGenreRepository Genre { get; set; }
        public IBiographyRepository Biography { get; set; }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose() 
        {
            _dbContext.Dispose();
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
