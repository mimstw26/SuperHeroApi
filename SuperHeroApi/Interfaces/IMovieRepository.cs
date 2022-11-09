using SuperHeroApi.Model;

namespace SuperHeroApi.Interfaces
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllAsync();
        Task<Movie> GetByIdAsync(string id);
    }
}
