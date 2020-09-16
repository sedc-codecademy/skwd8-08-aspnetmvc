using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PizzaApp.Services.Services.Interfaces;

namespace PizzaApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPizzaService _pizzaService;
        public HomeController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Menu()
        {
            var pizzas = _pizzaService.GetPizzas();

            return View(pizzas);
        }

        [Route("home/singlePizza/{id}/")]
        public IActionResult GetPizzaById(int id)
        {
            var pizza = _pizzaService.GetPizzaById(id);
            return View("SinglePizza", pizza);
        }
    }
}
