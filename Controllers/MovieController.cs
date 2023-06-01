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
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            var movies = await movieService.GetAllAsync();

            //Sorting:
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewBag.GenreSortParm = sortOrder == "genre" ? "genre_desc" : "genre";
            ViewBag.DateSortParm = sortOrder == "date" ? "date_desc" : "date";
            var sortedMovies = from m in movies select m;

            //Filtering by actor name:
            if (!String.IsNullOrEmpty(searchString))
            {
                sortedMovies = movies.Where(m => m.Actors.Any(a => a.Name.Contains(searchString))).ToList();
            }

            switch (sortOrder)
            {
                case "title_desc":
                    sortedMovies = sortedMovies.OrderByDescending(s => s.Title);
                    break;
                case "genre":
                    sortedMovies = sortedMovies.OrderBy(s => s.Genre);
                    break;
                case "genre_desc":
                    sortedMovies = sortedMovies.OrderByDescending(s => s.Genre);
                    break;
                case "date":
                    sortedMovies = sortedMovies.OrderBy(s => s.PremiereDate);
                    break;
                case "date_desc":
                    sortedMovies = sortedMovies.OrderByDescending(s => s.PremiereDate);
                    break;
                default:
                    sortedMovies = sortedMovies.OrderBy(s => s.Title);
                    break;
            }

            return View(sortedMovies);
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
