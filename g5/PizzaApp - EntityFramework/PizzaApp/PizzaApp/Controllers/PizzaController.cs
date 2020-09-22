using System;
using System.Linq;
using DomainModels;
using Microsoft.AspNetCore.Mvc;
using Services.Implementations;
using Services.Interfaces;
using ViewModels;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        public IActionResult Index()
        {
            var pizzas = _pizzaService.GetAll();
            return View(pizzas);
        }

        public IActionResult Details(int id)
        {
            try
            {
                var pizza = _pizzaService.GetById(id);
                return View(pizza);
            }
            catch (Exception ex)
            {
                return View("Error", ex.Message);
            }
        }

        public IActionResult Edit(int id)
        {
            var pizza = _pizzaService.GetById(id);
            return View(pizza);
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

            try
            {
                _pizzaService.Save(pizza);
            }
            catch (Exception ex)
            {
                return View("Error", ex.Message);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _pizzaService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
