using MongoDB.Driver;
using SuperHeroApi.Data;
using SuperHeroApi.Interfaces;
using SuperHeroApi.Model;

namespace SuperHeroApi.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public MovieRepository(ApplicationDbContext _appDbContext)
        {
            this._appDbContext = _appDbContext ?? throw new ArgumentNullException(nameof(_appDbContext));
        }

        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            return await _appDbContext.Movie.Find(_ => true).ToListAsync();
        }

        public async Task<Movie> GetByIdAsync(string id)
        {
            var filter = Builders<Movie>.Filter.Eq(_ => _.Id, id);

            return await _appDbContext.Movie.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<Movie> InsertAsync(Movie entity)
        {
            await _appDbContext.Movie.InsertOneAsync(entity);

            return entity;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            var result = await _appDbContext.Movie.DeleteOneAsync(Builders<Movie>.Filter.Eq(_ => _.Id, id));

            return result.DeletedCount > 0;
        }
    }
}
