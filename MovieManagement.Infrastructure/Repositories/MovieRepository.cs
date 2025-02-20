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

        public async Task<List<Movie>> GetAllAsync()
        {
            var movies = await _appDbContext.Movies.ToListAsync();
            return movies;
        }

        public async Task<Movie?> GetByIdAsync(int id)
        {
            var movie = await _appDbContext.Movies.FirstOrDefaultAsync(e => e.MovieId == id);
            return movie;
        }

        public async Task UpdateAsync(Movie movie)
        {
            _appDbContext.Entry(movie).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var movie = await GetByIdAsync(id);
            if (movie is not null)
            {
                _appDbContext.Movies.Remove(movie);
                await _appDbContext.SaveChangesAsync();
            }
        }
    }
}