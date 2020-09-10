using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Helper;
using PizzaApp.Models.DomainModels;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            var pizzasViewModels = Data.Pizzas.Select(Pizza.ToViewModel).ToList();
            return View(pizzasViewModels);
        }

        public IActionResult Details(int id)
        {
            var pizza = Data.Pizzas.FirstOrDefault(x => x.Id == id);

            if (pizza == null)
            {
                return NotFound();
            }

            return View(Pizza.ToViewModel(pizza));
        }

        public IActionResult Edit(int id)
        {
            var pizza = Data.Pizzas.FirstOrDefault(x => x.Id == id);

            if (pizza == null)
            {
                return NotFound();
            }

            return View(Pizza.ToViewModel(pizza));
        }

        public IActionResult Add()
        {
            return View("Edit", new PizzaViewModel());
        }

        [HttpPost]
        public IActionResult Save(PizzaViewModel pizza)
        {
            if (pizza == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View("Edit", pizza);
            }

            Pizza existingPizza = Data.Pizzas.FirstOrDefault(x => x.Id == pizza.Id);

            if (existingPizza == null)
            {
                Pizza newPizza = new Pizza
                {
                    Id = pizza.Id,
                    Name = pizza.Name,
                    Description = pizza.Description,
                    ImageUrl = pizza.ImageUrl
                };

                Data.Pizzas.Add(newPizza);
                return RedirectToAction("Index");
            }

            int indexOfExistingPizza = Data.Pizzas.IndexOf(existingPizza);
            Data.Pizzas.RemoveAt(indexOfExistingPizza);

            existingPizza.Name = pizza.Name;
            existingPizza.Description = pizza.Description;
            existingPizza.ImageUrl = pizza.ImageUrl;

            Data.Pizzas.Add(existingPizza);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Pizza existingPizza = Data.Pizzas.FirstOrDefault(x => x.Id == id);

            if (existingPizza == null)
            {
                return NotFound();
            }

            int indexOfExistingPizza = Data.Pizzas.IndexOf(existingPizza);
            Data.Pizzas.RemoveAt(indexOfExistingPizza);

            return RedirectToAction("Index");
        }
    }
}
