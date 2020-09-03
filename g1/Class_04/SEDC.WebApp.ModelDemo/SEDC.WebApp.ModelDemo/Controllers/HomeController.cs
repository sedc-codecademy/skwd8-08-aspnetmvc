using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.Models;
using SEDC.WebApp.ModelDemo.Models.ViewModels;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Heading"] = "Pizzas menu";
            ViewBag.Title = "Welcome to our pizza app!";
            var allPizzas = StaticDb.Menu;

            // How we map list of Pizza (domain model) to list of PizzaVM (viewModel)
            var allPizzasVM = allPizzas.Select(pizza => new PizzaVM()
            {
                Name = pizza.Name,
                Size = pizza.Size,
                Id = pizza.Id,
                ImageUrl = pizza.ImageUrl,
                Price = pizza.Price
            }).ToList();
            return View(allPizzasVM);
        }

        public IActionResult PizzaDetails(int id)
        {
            var pizza = StaticDb.Menu.SingleOrDefault(p => p.Id == id);
            // How we map Pizza (domain model) to PizzaVM (view model)
            PizzaVM pizzaModel = new PizzaVM()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Size = pizza.Size,
                Price = pizza.Price
            };
            return View(pizzaModel);
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
