using Microsoft.AspNetCore.Mvc;
using PizzaApp.MVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.MVC1.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet("pizza/menu")]
        public IActionResult GetMenu()
        {
            List<Pizza> pizzas = new List<Pizza>() { new Pizza() { ID = 1, Name = "Capri", Size = "Medium", Price = 13.5 },
                                                     new Pizza() { ID = 2, Name = "Funghi", Size = "Large", Price = 15.7 },
                                                     new Pizza() { ID = 3, Name = "Pepperoni", Size = "Small", Price = 10.4 }};

            return View(pizzas);
        }

        [Route("pizza/getOrder/{name}")]
        public IActionResult GetOrderWithPeperoniPizza(string name)
        {
            List<Pizza> pizzas = new List<Pizza>() { new Pizza() { ID = 1, Name = "Capri", Size = "Medium", Price = 13.5 },
                                                     new Pizza() { ID = 2, Name = "Funghi", Size = "Large", Price = 15.7 },
                                                     new Pizza() { ID = 3, Name = "Pepperoni", Size = "Small", Price = 10.4 }};
            Pizza peperoniPizza = pizzas.SingleOrDefault(p => p.Name == name);
            if (peperoniPizza == null)
            {
                throw new ApplicationException("The pizza does not exists");
            }
            Order order1 = new Order() { OrderId = 1, OrderDate = new System.DateTime(2020, 03, 20), Pizza = peperoniPizza,
                User = new User() { FirstName = "Jon", Address = "9th Ave", Email = "jonjonsky@gmail.com", ID = 1, LastName = "Jonsky", PhoneNumber = "071-111-111" } };

            return View(order1);
        }

        [Route("pizza/viewBag")]
        public IActionResult GetPizzasWithViewBag()
        {
            Pizza pizza = new Pizza() { ID = 1, Name = "Capri", Size = "Medium", Price = 13.5 };
            Pizza pizza2 = new Pizza() { ID = 2, Name = "Funghi", Size = "Large", Price = 15.7 };


            ViewBag.Heading = pizza.Name;
            ViewBag.PizzaSize = pizza.Size;

            return View();
        }




    }
}