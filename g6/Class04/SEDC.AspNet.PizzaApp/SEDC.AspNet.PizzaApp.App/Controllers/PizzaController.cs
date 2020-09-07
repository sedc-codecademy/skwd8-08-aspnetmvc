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

        [HttpGet("edit/{id:int}")]
        public IActionResult EditPizza(int id)
        {
            var pizza = Database.Menu.FirstOrDefault(x => x.Id == id);

            var pizzaVm = new PizzaVM
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                Size = pizza.Size
            };

            return View("Edit", pizzaVm);
        }

        [HttpPost("edit/{id:int}")]
        public IActionResult EditPizza(PizzaVM pizzaVM)
        {
            if(pizzaVM.Name == null)
            {
                ModelState.AddModelError("Size", "This is just for demo");
                return View("Edit", pizzaVM);
            }

            if(!ModelState.IsValid)
            {
                return View("Edit", pizzaVM);
            }

            var pizzaDb = Database.Menu.FirstOrDefault(x => x.Id == pizzaVM.Id);

            pizzaDb.Name = pizzaVM.Name;
            pizzaDb.Price = pizzaVM.Price;
            pizzaDb.Size = pizzaVM.Size;

            return RedirectToAction("GetAll"); 
        }
    }
}
