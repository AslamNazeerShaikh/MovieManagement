using Microsoft.EntityFrameworkCore;
using MovieManagement.Application.Interfaces;
using MovieManagement.Domain.Entities;
using MovieManagement.Infrastructure.Context;

namespace MovieManagement.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _appDbContext;

        public MovieRepository(IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _appDbContext = dbContextFactory.CreateDbContext();
        }
        public async Task AddAsync(Movie movie)
        {
            _appDbContext.Movies.Add(movie);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
