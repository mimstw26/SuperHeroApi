using SuperHeroApi.Model;

namespace SuperHeroApi.Data
{
    public class Subscriptions
    {
        [Subscribe]
        [Topic]
        public Task<Movie> OnCreateAsync([EventMessage] Movie movie) =>
            Task.FromResult(movie);

        // not working yet
        [Subscribe]
        [Topic]
        public Task<bool> OnRemoveAsync([EventMessage] bool removed) =>
            Task.FromResult(removed);
    }
}
