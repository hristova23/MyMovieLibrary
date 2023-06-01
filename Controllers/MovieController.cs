using Microsoft.AspNetCore.Mvc;
using MyMovieLibrary.Models;
using MyMovieLibrary.Services.Contracts;

namespace MyMovieLibrary.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService movieService;
        private readonly IGenreService genreService;

        public MovieController(IMovieService _bookService, IGenreService _genreService)
        {
            movieService = _bookService;
            genreService = _genreService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await movieService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AddMovieVM()
            {
                Genres = await genreService.GetGenresAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddMovieVM model)
        {
            if (!ModelState.IsValid)
            {
                model.Genres = await genreService.GetGenresAsync();

                return View(model);
            }

            try
            {
                List<string> actorsNames = model.ActorsNames.Split(", ").ToList();

                var movieToAdd = new AddMovieVM
                {
                    Title = model.Title,
                    GenreId = model.GenreId,
                    PremiereDate = model.PremiereDate,
                    Actors = actorsNames.Select(a => new ActorVM()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = a
                    }).ToList()
                };

                await movieService.AddMovieAsync(movieToAdd);

                return RedirectToAction("Index", "Movie");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");

                return View(model);
            }
        }
    }
}
