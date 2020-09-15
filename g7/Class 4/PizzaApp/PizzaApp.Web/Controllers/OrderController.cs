using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Web.Models.Domain;
using PizzaApp.Web.Models.Enums;
using PizzaApp.Web.Models.ViewModels;

namespace PizzaApp.Web.Controllers
{
    public class OrderController : Controller
    {
        public User User { get; set; }

        public List<Pizza> Pizzas { get; set; } = new List<Pizza>
        {
            new Pizza{ Id = 1, Name = "Pizza 1"},
            new Pizza{ Id = 2, Name = "Pizza 2"},
            new Pizza{ Id = 3, Name = "Pizza 3"},
            new Pizza{ Id = 4, Name = "Pizza 4"},
        };

<<<<<<< HEAD
        public List<string> PizzaNames = new List<string>();

        private static List<OrderViewModel> Orders = new List<OrderViewModel>();
=======
        public static List<OrderViewModel> Orders { get; set; } = new List<OrderViewModel>();
>>>>>>> 1cd30a1651bab29babd836b7779d780b70744e25

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "Wlcome to Pizza-App orders";
            return View("Order", Orders);
        }

        [HttpGet]
        public IActionResult PlaceOrder()
        {
            
            ViewBag.Title = "Place an order";

<<<<<<< HEAD
            PizzaNames = Pizzas.Select(x => x.Name).ToList();

            ViewData["Pizzas"] = PizzaNames;
=======
            var pizzasNames = Pizzas.Select(x => x.Name).ToList();

            ViewData["Pizzas"] = pizzasNames;
>>>>>>> 1cd30a1651bab29babd836b7779d780b70744e25

            ViewData["PizzaSize"] = Enum.GetValues(typeof(PizzaSize)).Cast<PizzaSize>().ToList();

            return View();
        }
<<<<<<< HEAD

=======
>>>>>>> 1cd30a1651bab29babd836b7779d780b70744e25
        [HttpPost]
        public IActionResult PlaceOrder(OrderViewModel order)
        {
            Orders.Add(order);
<<<<<<< HEAD
            return RedirectToAction("Index", order);
        }

        public IActionResult EditOder()
        {
            return View();
=======
            return RedirectToAction("Index","Order",order);
>>>>>>> 1cd30a1651bab29babd836b7779d780b70744e25
        }
    }
}
