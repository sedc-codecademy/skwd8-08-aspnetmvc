using Microsoft.AspNetCore.Mvc;
using NTierApp.Services.Services.Interfaces;

namespace NTierApp.MVC.Controllers
{
    public class MovieController : Controller
    {
        private IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            var movies = _movieService.GetMoviesRepertuar();
            return View(movies);
        }
    }
}
