using SuperHeroApi.Model;

namespace SuperHeroApi.Interfaces
{
    public interface ISuperpowerRepository
    {
        Task<IEnumerable<Superpower>> GetAllAsync();
        Task<Superpower> GetByIdAsync(string id);
    }
}
