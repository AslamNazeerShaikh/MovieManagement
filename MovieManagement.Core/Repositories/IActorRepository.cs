using MovieManagement.Core.Entities;

namespace MovieManagement.Core.Repositories
{
    public interface IActorRepository : IGenericRepository<Actor>
    {
        public Task<IEnumerable<Actor>> GetPopularActorsAsync();
    }
}
