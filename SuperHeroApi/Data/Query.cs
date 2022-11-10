using SuperHeroApi.Interfaces;
using SuperHeroApi.Model;

namespace SuperHeroApi.Data
{
    public class Query
    {
        // movies
        public Task<IEnumerable<Movie>> GetMoviesAsync([Service] IMovieRepository movieRepository) =>
            movieRepository.GetAllAsync();

        public Task<Movie> GetMovieById(string id, [Service] IMovieRepository movieRepository) =>
            movieRepository.GetByIdAsync(id);


        // superpowers
        public Task<IEnumerable<Superpower>>
            GetSuperpowersAsync([Service] ISuperpowerRepository superpowerRepository) =>
            superpowerRepository.GetAllAsync();

        public Task<Superpower> GetSuperpowerById(string id, [Service] ISuperpowerRepository superpowerRepository) =>
            superpowerRepository.GetByIdAsync(id);


        // superheros
        public Task<IEnumerable<Superhero>> GetSuperherosAsync([Service] ISuperheroRepository superheroRepository) =>
            superheroRepository.GetAllAsync();

        public Task<Superhero> GetSuperheroById(string id, [Service] ISuperheroRepository superheroRepository) =>
            superheroRepository.GetByIdAsync(id);
    }
}