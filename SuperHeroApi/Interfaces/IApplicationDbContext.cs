using MongoDB.Driver;
using SuperHeroApi.Model;

namespace SuperHeroApi.Interfaces
{
    public interface IApplicationDbContext
    {
        IMongoCollection<T> GetCollection<T>(string name);
    }
}
