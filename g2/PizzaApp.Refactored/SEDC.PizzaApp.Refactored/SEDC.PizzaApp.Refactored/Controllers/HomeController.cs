using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Refactored.Models;
using SEDC.PizzaApp.Services.Services;

namespace SEDC.PizzaApp.Refactored.Controllers
{
    public class HomeController : Controller
    {
        private IPizzaOrderService _pizzaOrderService;
        public HomeController()
        {
            _pizzaOrderService = new PizzaOrderService();
        }

        public IActionResult Index()
        {
            return View(new HomeViewModel());
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel model)
        {
            return RedirectToAction("Order", "Order", new { pizzas = model.NumberOfPizzas });
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

        public IActionResult Menu()
        {
            List<Pizza> menu = _pizzaOrderService.GetMenu();
            List<PizzaViewModel> pizzasView = new List<PizzaViewModel>();

            foreach (var pizza in menu)
            {
                pizzasView.Add(new PizzaViewModel()
                {
                    Id = pizza.Id,
                    Image = pizza.Image,
                    Name = pizza.Name,
                    Price = pizza.Price,
                    Size = pizza.PizzaSize
                });
            }
            MenuViewModel model = new MenuViewModel()
            {
                Pizzas = pizzasView
            };
            return View(model);
        }
    }
}
