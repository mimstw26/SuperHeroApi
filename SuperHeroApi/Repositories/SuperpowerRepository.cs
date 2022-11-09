using MongoDB.Driver;
using SuperHeroApi.Data;
using SuperHeroApi.Interfaces;
using SuperHeroApi.Model;

namespace SuperHeroApi.Repositories
{
    public class SuperpowerRepository : ISuperpowerRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public SuperpowerRepository(ApplicationDbContext _appDbContext)
        {
            this._appDbContext = _appDbContext ?? throw new ArgumentNullException(nameof(_appDbContext));
        }

        public async Task<IEnumerable<Superpower>> GetAllAsync()
        {
            return await _appDbContext.Superpower.Find(_ => true).ToListAsync();
        }

        public async Task<Superpower> GetByIdAsync(string id)
        {
            var filter = Builders<Superpower>.Filter.Eq(_ => _.Id, id);

            return await _appDbContext.Superpower.Find(filter).FirstOrDefaultAsync();
        }
    }
}
