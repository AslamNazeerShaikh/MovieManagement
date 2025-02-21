namespace MovieManagement.Application.Interfaces;

public interface IUnitOfWork : IDisposable
{
    public IMovieRepository Movie { get; }
    public Task<int> SaveAsync();
}