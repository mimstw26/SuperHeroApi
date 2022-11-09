using SuperHeroApi.Model;

namespace SuperHeroApi.Interfaces
{
    public interface ISuperheroRepository
    {
        Task<IEnumerable<Superhero>> GetAllAsync();
        Task<Superhero> GetByIdAsync(string id);
    }
}
