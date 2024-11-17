using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieManagement.Core.Repositories;
using MovieManagement.Data.Context;

namespace MovieManagement.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;

        public UnitOfWork(ApplicationDbContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;

            Actors = new ActorRepository(context);
            Movies = new MovieRepository(context);
            Genres = new GenreRepository(context);
        }

        public IActorRepository Actors { get; }
        public IMovieRepository Movies { get; }
        public IGenreRepository Genres { get; }

        public async Task<int> SaveChangesAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.Error(ex, "Concurrency issue occurred while saving changes.");
                throw;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "An error occurred while saving changes.");
                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
