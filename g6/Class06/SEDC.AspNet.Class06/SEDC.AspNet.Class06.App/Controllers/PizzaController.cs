using Microsoft.AspNetCore.Mvc;
using SEDC.AspNet.Class06.BusinessLayer.Interfaces;
using SEDC.AspNet.Class06.BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Class06.App.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaService _pizzaService;

        public PizzaController()
        {
            _pizzaService = new PizzaService();
        }

        public IActionResult Index()
        {
            var pizzas = _pizzaService.GetAllPizzas();

            return View(pizzas);
        }
    }
}
