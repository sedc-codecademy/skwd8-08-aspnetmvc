using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.Services.Interfaces;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    public class HomeController : Controller
    {
        private IPizzaService _pizzaService;
        public HomeController(IPizzaService pizzas)
        {
            _pizzaService = pizzas;
        }
        public IActionResult Index()
        {
            ViewData["Heading"] = "Pizzas menu";
            ViewBag.Title = "Welcome to our pizza app!";
            var allPizzas = _pizzaService.GetAllPizzas();

            // How we map list of Pizza (domain model) to list of PizzaVM (viewModel)
            return View(allPizzas);
        }

        public IActionResult PizzaDetails(int id)
        {
           
            return View();
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

    }
}
