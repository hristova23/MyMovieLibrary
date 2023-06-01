using Microsoft.AspNetCore.Mvc;

namespace MyMovieLibrary.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
