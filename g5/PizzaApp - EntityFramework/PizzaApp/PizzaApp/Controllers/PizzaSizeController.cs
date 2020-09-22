using System.Collections.Generic;
using System.Linq;
using DomainModels;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Helper;
using Services.Interfaces;
using ViewModels;

namespace PizzaApp.Controllers
{
    public class PizzaSizeController : Controller
    {
        private readonly IPizzaSizeService _pizzaSizeService;
        private readonly IPizzaService _pizzaService;
        private readonly ISizeService _sizeService;

        public PizzaSizeController(IPizzaSizeService pizzaSizeService, IPizzaService pizzaService, ISizeService sizeService)
        {
            _pizzaSizeService = pizzaSizeService;
            _pizzaService = pizzaService;
            _sizeService = sizeService;
        }

        public IActionResult Index()
        {
            return View(_pizzaSizeService.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(_pizzaSizeService.GetById(id));
        }

        public IActionResult Edit(int id)
        {
            List<SizeViewModel> sizes = _sizeService.GetAll();
            ViewBag.SizesForSelection = sizes.ToSelectListItems();

            List<PizzaViewModel> pizzas = _pizzaService.GetAll();
            ViewBag.PizzasForSelection = pizzas.ToSelectListItems();
            return View(_pizzaSizeService.GetById(id));
        }

        public IActionResult Add()
        {
            List<SizeViewModel> sizes = _sizeService.GetAll();
            ViewBag.SizesForSelection = sizes.ToSelectListItems();

            List<PizzaViewModel> pizzas = _pizzaService.GetAll();
            ViewBag.PizzasForSelection = pizzas.ToSelectListItems();

            return View("Edit", new PizzaSizeViewModel());
        }

        public IActionResult Save(PizzaSizeViewModel pizzaSize)
        {
            if (pizzaSize == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View("Edit", pizzaSize);
            }

            _pizzaSizeService.Save(pizzaSize);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _pizzaSizeService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
