using MovieManagement.Domain.Entities;

namespace MovieManagement.Application.Interfaces
{
    public interface IMovieRepository
    {
        public Task AddAsync(Movie movie);
    }
}
