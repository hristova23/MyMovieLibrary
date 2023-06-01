using Microsoft.AspNetCore.Mvc;
using MyMovieLibrary.Services.Contracts;

namespace MyMovieLibrary.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService movieService;

        public MovieController(IMovieService _bookService)
        {
            movieService = _bookService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await movieService.GetAllAsync();

            return View(model);
        }
    }
}
