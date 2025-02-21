using Microsoft.EntityFrameworkCore;
using MovieManagement.Application.Interfaces;
using MovieManagement.Domain.Entities;
using MovieManagement.Infrastructure.Context;

namespace MovieManagement.Infrastructure.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        private readonly AppDbContext _appDbContext;

        public MovieRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Movie> GetMovieByName(string name)
        {
            return await _appDbContext.Movies.FirstOrDefaultAsync(x => x.MovieName == name) ??
                   throw new ArgumentNullException();
        }
    }
}