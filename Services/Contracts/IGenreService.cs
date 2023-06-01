using MyMovieLibrary.Models;

namespace MyMovieLibrary.Services.Contracts
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreVM>> GetGenresAsync();
    }
}
