using System.Collections.Generic;
using System.Linq;
using DomainModels;
using Microsoft.AspNetCore.Mvc;
using ViewModels;

namespace PizzaApp.Controllers
{
    public class PizzaSizeController : Controller
    {
        //public IActionResult Index()
        //{
        //    //List<PizzaSize> pizzaSizes = Data.PizzaSizes;
        //    //List<PizzaSizeViewModel> pizzaSizeViewModels = pizzaSizes.Select(x => PizzaSize.ToViewModel(x)).ToList();

        //    List<PizzaSizeViewModel> pizzaSizeViewModels = Data.PizzaSizes.Select(PizzaSize.ToViewModel).ToList();

        //    return View(pizzaSizeViewModels);
        //}

        //public IActionResult Details(int id)
        //{
        //    PizzaSize pizzaSize = Data.PizzaSizes.FirstOrDefault(x => x.Id == id);

        //    if (pizzaSize == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(PizzaSize.ToViewModel(pizzaSize));
        //}

        //public IActionResult Edit(int id)
        //{
        //    PizzaSize pizzaSize = Data.PizzaSizes.FirstOrDefault(x => x.Id == id);

        //    if (pizzaSize == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(PizzaSize.ToViewModel(pizzaSize));
        //}

        //public IActionResult Add()
        //{
        //    return View("Edit", new PizzaSizeViewModel());
        //}

        //public IActionResult Save(PizzaSizeViewModel pizzaSize)
        //{
        //    if (pizzaSize == null)
        //    {
        //        return BadRequest();
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return View("Edit", pizzaSize);
        //    }

        //    PizzaSize existingPizzaSize = Data.PizzaSizes.FirstOrDefault(x => x.Id == pizzaSize.Id);

        //    if (existingPizzaSize == null)
        //    {
        //        PizzaSize newPizzaSize = new PizzaSize(pizzaSize.PizzaId, pizzaSize.SizeId, pizzaSize.Price);

        //        Data.PizzaSizes.Add(newPizzaSize);
        //        return RedirectToAction("Index");
        //    }

        //    int index = Data.PizzaSizes.IndexOf(existingPizzaSize);
        //    Data.PizzaSizes.RemoveAt(index);

        //    existingPizzaSize.PizzaId = pizzaSize.PizzaId;
        //    existingPizzaSize.Pizza = Data.Pizzas.FirstOrDefault(x => x.Id == pizzaSize.PizzaId);
        //    existingPizzaSize.SizeId = pizzaSize.SizeId;
        //    existingPizzaSize.Size = Data.Sizes.FirstOrDefault(x => x.Id == pizzaSize.SizeId);
        //    existingPizzaSize.Price = pizzaSize.Price;

        //    Data.PizzaSizes.Add(existingPizzaSize);
        //    return RedirectToAction("Index");
        //}

        //public IActionResult Delete(int id)
        //{
        //    PizzaSize pizzaSize = Data.PizzaSizes.FirstOrDefault(x => x.Id == id);

        //    if (pizzaSize == null)
        //    {
        //        return NotFound();
        //    }

        //    int index = Data.PizzaSizes.IndexOf(pizzaSize);
        //    Data.PizzaSizes.RemoveAt(index);

        //    return RedirectToAction("Index");
        //}
    }
}
