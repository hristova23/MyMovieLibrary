using MyMovieLibrary.Data.Common;
using MyMovieLibrary.Data.Models;
using MyMovieLibrary.Services.Contracts;

namespace MyMovieLibrary.Services
{
    public class ActorService : IActorService
    {
        private readonly IRepository repo;

        public ActorService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task AddActorAsync(string id, string name)
        {
            var actor = new Actor()
            {
                Id = Guid.Parse(id),
                Name = name
            };

            await repo.AddAsync(actor);
            await repo.SaveChangesAsync();
        }
    }
}
