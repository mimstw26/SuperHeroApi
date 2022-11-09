using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using SuperHeroApi.Repositories;

namespace SuperHeroApi.Model
{
    public class Superhero : BaseEntity
    {
        [Required(ErrorMessage = "Please specify a name for the superhero")]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Height { get; set; }

        //public IMongoCollection<Superpower>? Superpowers { get; set; }

        //public IMongoCollection<Movie>? Movies { get; set; }
    }
}
