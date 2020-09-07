using Microsoft.AspNetCore.Mvc;
using SEDC.AspNet.PizzaApp.App.InMemoryDatabase;
using SEDC.AspNet.PizzaApp.App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.PizzaApp.App.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet("pizzas")]
        public IActionResult GetAll()
        {
            var pizzas = Database.Menu;

            var listOfPizzasVM = new List<PizzaVM>();
            foreach (var pizza in pizzas)
            {
                var pizzaVm = new PizzaVM
                {
                    Id = pizza.Id,
                    Name = pizza.Name,
                    Price = pizza.Price,
                    Size = pizza.Size
                };
                listOfPizzasVM.Add(pizzaVm);
            }

            return View("Index", listOfPizzasVM);
        }
    }
}
