using MovieManagement.Domain.Entities;

namespace MovieManagement.Application.Interfaces
{
    public interface IMovieRepository
    {
        public Task AddAsync(Movie movie);
        public Task<List<Movie>> GetAllAsync();
        public Task<Movie?> GetByIdAsync(int id);
        public Task UpdateAsync(Movie movie);
        public Task DeleteByIdAsync(int id);
    }
}