using Microsoft.AspNetCore.Mvc;
using PizzaApp.Web.Models.Domain;
using System.Collections.Generic;

namespace PizzaApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Order> orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    Pizza = new Pizza
                    {
                        Name = "Pizza1"
                    },
                    Price = 600
                },
                                new Order
                {
                    Id = 2,
                    Pizza = new Pizza
                    {
                        Name = "Pizza2"
                    },
                    Price = 700
                }
            };

            return View("Home", orders);
        }

        public IActionResult About()
        {
            return View("About");
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
