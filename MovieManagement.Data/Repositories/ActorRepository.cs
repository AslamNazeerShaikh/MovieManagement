using Microsoft.EntityFrameworkCore;
using MovieManagement.Core.Entities;
using MovieManagement.Core.Repositories;
using MovieManagement.Data.Context;

namespace MovieManagement.Data.Repositories
{
    public class ActorRepository(ApplicationDbContext dbContext) : GenericRepository<Actor>(dbContext), IActorRepository
    {
        public async Task<IEnumerable<Actor>> GetPopularActorsAsync()
        {
            // Example custom query
            return await _dbSet.Where(actor => actor.ActorName != null && actor.ActorName.StartsWith('A')).ToListAsync();
        }
    }
}
