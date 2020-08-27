using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApp.Models;

namespace MyFirstMVCApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Order() 
        {
            var pizza = new Pizza();
            pizza.PizzaName = "Capricciosa";
            pizza.Size = 30;

            return View(pizza);
        }
    }
}
