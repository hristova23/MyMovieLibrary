using Microsoft.EntityFrameworkCore;
using MyMovieLibrary.Data.Common;
using MyMovieLibrary.Data.Models;
using MyMovieLibrary.Models;
using MyMovieLibrary.Services.Contracts;

namespace MyMovieLibrary.Services
{
    public class GenreService : IGenreService
    {
        private readonly IRepository repo;

        public GenreService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<GenreVM>> GetGenresAsync()
        {
            return await repo.AllReadonly<Genre>()
                .OrderBy(g => g.Name)
                .Select(g => new GenreVM()
                {
                    Id = g.Id.ToString(),
                    Name = g.Name
                })
                .ToListAsync();
        }
    }
}