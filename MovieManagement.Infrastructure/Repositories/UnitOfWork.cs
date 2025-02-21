using MovieManagement.Application.Interfaces;
using MovieManagement.Infrastructure.Context;

namespace MovieManagement.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _dbContext;
    private bool _disposed = false;

    public UnitOfWork(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        Movie = new MovieRepository(dbContext);
    }

    public IMovieRepository? Movie { get; set; }

    public async Task<int> SaveAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }

    // Dispose pattern
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Dispose of managed resources (e.g., DbContext)
                _dbContext.Dispose();
            }

            // Dispose of unmanaged resources if necessary
            _disposed = true;
        }
    }

    // Public Dispose method that calls the protected Dispose method
    public void Dispose()
    {
        // Call the protected Dispose method with disposing = true
        Dispose(true);

        // Suppress finalization to prevent the finalizer from running when the object is disposed
        GC.SuppressFinalize(this);
    }

    // Finalizer to handle cases where Dispose isn't called
    ~UnitOfWork()
    {
        Dispose(false);
    }
}