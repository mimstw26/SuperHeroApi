using MongoDB.Driver;
using SuperHeroApi.Data;
using SuperHeroApi.Interfaces;
using SuperHeroApi.Model;

namespace SuperHeroApi.Repositories
{
    public class SuperheroRepository : ISuperheroRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public SuperheroRepository(ApplicationDbContext _appDbContext)
        {
            this._appDbContext = _appDbContext ?? throw new ArgumentNullException(nameof(_appDbContext));
        }

        public async Task<IEnumerable<Superhero>> GetAllAsync()
        {
            return await _appDbContext.Superhero.Find(_ => true).ToListAsync();
        }

        public async Task<Superhero> GetByIdAsync(string id)
        {
            var filter = Builders<Superhero>.Filter.Eq(_ => _.Id, id);

            return await _appDbContext.Superhero.Find(filter).FirstOrDefaultAsync();
        }
    }
}
