using Microsoft.EntityFrameworkCore;
using MyMovieLibrary.Data.Common;
using MyMovieLibrary.Data.Models;
using MyMovieLibrary.Models;
using MyMovieLibrary.Services.Contracts;

namespace MyMovieLibrary.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository repo;
        private readonly IActorService actorService;

        public MovieService(IRepository _repo, IActorService _actorService)
        {
            repo = _repo;
            actorService = _actorService;
        }

        public async Task<IEnumerable<MovieVM>> GetAllAsync()
        {
            return await repo.AllReadonly<Movie>()
                //.OrderByDescending(b => b.Id)
                .Select(m => new MovieVM()
                {
                    Id = m.Id.ToString(),
                    Title = m.Title,
                    Genre = m.Genre.Name,
                    PremiereDate = m.PremiereDate,
                    Actors = m.Actors.Select(a => new ActorVM()
                    {
                        Id = a.Actor.Id.ToString(),
                        Name = a.Actor.Name,
                    }).ToList(),
                })
                .ToListAsync();
        }

        public async Task AddMovieAsync(AddMovieVM model)
        {
            //Adding actors to db
            foreach (var actor in model.Actors)
            {
                await actorService.AddActorAsync(actor.Id, actor.Name);
            }

            //Adding movie to db
            var movie = new Movie()
            {
                Title = model.Title,
                GenreId = Guid.Parse(model.GenreId),
                PremiereDate = model.PremiereDate,
                Actors = model.Actors.Select(a => new MovieActor()
                {
                    ActorId = Guid.Parse(a.Id),
                    MovieId = Guid.NewGuid()
                }).ToList()
            };

            await repo.AddAsync(movie);
            await repo.SaveChangesAsync();
        }
    }
}
