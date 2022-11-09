using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using SuperHeroApi.Repositories;

namespace SuperHeroApi.Model
{
    public class Movie : BaseEntity
    {

        [Required(ErrorMessage = "The movie title is required")]
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Instructor { get; set; }
        public DateTime ReleaseDate { get; set; }

        public string? SuperheroId { get; set; }
    }
}
