using HotChocolate.Subscriptions;
using SuperHeroApi.Interfaces;
using SuperHeroApi.Model;

namespace SuperHeroApi.Data
{
    public class Mutations
    {
        public async Task<Movie> CreateMovieAsync(Movie movie, [Service] IMovieRepository movieRepository, [Service] ITopicEventSender eventSender)
        {
            var result = await movieRepository.InsertAsync(movie);
            await eventSender.SendAsync(nameof(Subscriptions.OnCreateAsync), result);
            return result;
        }

        public async Task<bool> RemoveMovieAsync(string id, [Service] IMovieRepository movieRepository,
            [Service] ITopicEventSender eventSender)
        {
            var result = await movieRepository.RemoveAsync(id);

            if (result)
            {
                await eventSender.SendAsync(new Subscriptions().OnRemoveAsync(result),result);
            }

            return result;
        }

        public Task<Superhero> CreateSuperheroAsync(Superhero superhero, [Service] ISuperheroRepository superheroRepository) =>
            superheroRepository.InsertAsync(superhero);
        public Task<bool> RemoveSuperheroAsync(string id, [Service] ISuperheroRepository superheroRepository) =>
            superheroRepository.RemoveAsync(id);

        public Task<Superpower> CreateSuperpowerAsync(Superpower superpower, [Service] ISuperpowerRepository superpowerRepository) =>
            superpowerRepository.InsertAsync(superpower);
        public Task<bool> RemoveSuperpowerAsync(string id, [Service] ISuperpowerRepository superpowerRepository) =>
            superpowerRepository.RemoveAsync(id);
    }
}
