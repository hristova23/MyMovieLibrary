using MyMovieLibrary.Models;

namespace MyMovieLibrary.Services.Contracts
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieVM>> GetAllAsync();
    }
}
