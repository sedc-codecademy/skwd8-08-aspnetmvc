using Microsoft.AspNetCore.Mvc;
using SEDC.AspNet.Class09.EfCodeFirst.Database.Interfaces;
using SEDC.AspNet.Class09.EfCodeFirst.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Class09.EfCodeFirst.Controllers
{
    public class MovieController : Controller
    {
        private readonly IRepository<Movie> _movieRepository;

        public MovieController(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IActionResult Index()
        {
            var movies = _movieRepository.GetAll();
            return View(movies);
        }
    }
}
