using MovieManagement.Core.Entities;
using MovieManagement.Core.Repositories;
using MovieManagement.Data.Context;

namespace MovieManagement.Data.Repositories
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Actor>> GetPopularActorsAsync()
        {
            // Example custom query
            return await _dbSet.Where(actor => actor.Name.StartsWith("A")).ToListAsync();
        }
    }
}
