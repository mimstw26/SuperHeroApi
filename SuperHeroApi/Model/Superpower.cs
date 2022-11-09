using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using SuperHeroApi.Repositories;

namespace SuperHeroApi.Model
{
    public class Superpower : BaseEntity
    {
        [Required(ErrorMessage = "The superpower is required")]
        public string? SuperPower { get; set; }
        public string? Description { get; set; }

        public string? SuperheroId { get; set; }
    }
}