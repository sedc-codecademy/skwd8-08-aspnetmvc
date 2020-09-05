using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.Models.ViewModels;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var domainPizza = StaticDb.Menu;

            // How we map list of Pizza (domain model) to list of PizzaVM (viewModel)
            var pizzasVM = domainPizza.Select(pizza => new PizzaVM()
            {
                Name = pizza.Name,
                Size = pizza.Size,
                Price = pizza.Price,
                Id = pizza.Id
            }).ToList();


            // How we map Pizza (domain model) to PizzaVM (view model)
            var pizzaVM = new PizzaVM()
            {
                Name = domainPizza[0].Name,
                Size = domainPizza[0].Size,
                Price = domainPizza[0].Price,
                Id = domainPizza[0].Id
            };
            ViewBag.Pizzas = pizzasVM;
            return View(pizzaVM);
        }

        public IActionResult Testing()
        {
            var domainPizza = StaticDb.Menu[0];

            // How we map Pizza (domain model) to PizzaVM (viewModel)
            var pizzaVM = new PizzaVM()
            {
                Name = domainPizza.Name,
                Size = domainPizza.Size,
                Price = domainPizza.Price,
                Id = domainPizza.Id
            };
            var pizza = new PizzaVM() { };
            return View(pizza);
        }

    }
}
