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
