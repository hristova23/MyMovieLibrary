using MyMovieLibrary.Data.Common;
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
    }
}
