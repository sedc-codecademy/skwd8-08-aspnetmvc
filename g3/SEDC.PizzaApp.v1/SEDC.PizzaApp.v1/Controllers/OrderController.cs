using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.v1.Models.DomainModels;
using SEDC.PizzaApp.v1.Models.Enum;
using SEDC.PizzaApp.v1.Models.ViewModels;

namespace SEDC.PizzaApp.v1.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            //transfer data form a Model          
            User person = new User()
            {
                FirstName = "Bob",
                LastName = "Bosky",
                Address = "Praska 90b",
                Phone = 12345,
            };

            Pizza pizza = new Pizza()
            {
                Name = "Capri",
                Size = PizzaSize.Family,
                Price = 12.50
            };

            Pizza pizza2 = new Pizza()
            {
                Name = "Quatro",
                Size = PizzaSize.Medium,
                Price = 8.50
            };

            Order order = new Order()
            {
                Id = 12,
                Price = pizza.Price + 2,
                User = person,
                IsDelivered = true,
                Pizzas = new List<Pizza>() { pizza, pizza2 }
            };

            //ViewData
            ViewData.Add("Title", "Welcome to our order page!");
            ViewData.Add("Username", person.FirstName);

            //ViewBag
            ViewBag.Greeting = "We have the best pizza in the world!";
            ViewBag.Pizza = pizza;

            return View(order);
        }

        public IActionResult Details(int? id) 
        {
            var order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);

            if (order == null) 
            {
                return RedirectToAction("Index");
            }

            //mapping
            var orderDetails = new OrderViewModel()
            {
                Id = order.Id,
                FullName = order.User.FirstName + " " + order.User.LastName,
                Address = order.User.Address,
                Contact = order.User.Phone,
                Price = order.Price,
                IsDelievered = order.IsDelivered,
                Pizzas = order.Pizzas
            };
            
            return View(orderDetails);
        }

        public IActionResult Menu() 
        {
            var dbMenu = StaticDb.Menu;

            var menu = new MenuViewModel()
            {
                Menu = dbMenu
            };

            return View(menu);
        }

    }
}
