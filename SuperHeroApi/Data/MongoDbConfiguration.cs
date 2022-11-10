namespace SuperHeroApi.Data
{
    public class MongoDbConfiguration
    {
        public string ConnectionString { get; set; } = null!;
        public string Database { get; set; } = null!;
        public string MoviesCollectionName { get; set; } = null!;
        public string SuperherosCollectionName { get; set; } = null!;
        public string SuperpowersCollectionName { get; set; } = null!;
    }
}
