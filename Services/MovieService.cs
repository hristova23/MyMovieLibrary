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

        public MovieService(IRepository _repo)
        {
            repo = _repo;
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
    }
}
