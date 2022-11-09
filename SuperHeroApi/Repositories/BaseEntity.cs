using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace SuperHeroApi.Repositories
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
