using MovieManagement.Core.Entities;
using MovieManagement.Core.Repositories;
using MovieManagement.Data.Context;

namespace MovieManagement.Data.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
