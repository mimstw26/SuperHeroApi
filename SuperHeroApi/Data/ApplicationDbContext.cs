using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SuperHeroApi.Interfaces;
using SuperHeroApi.Model;

namespace SuperHeroApi.Data
{
    public class ApplicationDbContext
    {
        public ApplicationDbContext(IOptions<MongoDbConfiguration> mongoDbConfiguration)
        {
            var client = new MongoClient(mongoDbConfiguration.Value.ConnectionString);
            var database = client.GetDatabase(mongoDbConfiguration.Value.Database);

            Movie = database.GetCollection<Movie>(mongoDbConfiguration.Value.MoviesCollectionName);
            Superhero = database.GetCollection<Superhero>(mongoDbConfiguration.Value.SuperherosCollectionName);
            Superpower = database.GetCollection<Superpower>(mongoDbConfiguration.Value.SuperpowersCollectionName);
        }

        public IMongoCollection<Movie> Movie { get; }
        public IMongoCollection<Superhero> Superhero { get; }
        public IMongoCollection<Superpower> Superpower { get; }
    }
}
