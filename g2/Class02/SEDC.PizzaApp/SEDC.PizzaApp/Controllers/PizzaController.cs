using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> allPizzas = StaticDb.Pizzas;
            return View(allPizzas);
        }

        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                return View();
            }

            return new EmptyResult();
        }

        [HttpGet("ListPizzas")]
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
            //return Redirect(); // requires full URL path
        }

        public IActionResult GetRawPizza(int id)
        {
            Pizza foundPizza = StaticDb.Pizzas.FirstOrDefault(p => p.Id == id);
            return new JsonResult(foundPizza);
        }


    }
}
