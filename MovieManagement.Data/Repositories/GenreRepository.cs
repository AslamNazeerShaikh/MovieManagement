using MovieManagement.Core.Entities;
using MovieManagement.Core.Repositories;
using MovieManagement.Data.Context;

namespace MovieManagement.Data.Repositories
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
