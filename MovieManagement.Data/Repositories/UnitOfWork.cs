using MovieManagement.Core.Repositories;
using MovieManagement.Data.Context;

namespace MovieManagement.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Actors = new ActorRepository(context);
            Movies = new MovieRepository(context);
            Genres = new GenreRepository(context);
        }

        public IActorRepository Actors { get; }
        public IMovieRepository Movies { get; }
        public IGenreRepository Genres { get; }

        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
