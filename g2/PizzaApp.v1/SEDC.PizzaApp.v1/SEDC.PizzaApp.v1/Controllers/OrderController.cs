using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.v1.DB;
using SEDC.PizzaApp.v1.Models.Domain;
using SEDC.PizzaApp.v1.Models.ViewModels;

namespace SEDC.PizzaApp.v1.Controllers
{
    public class OrderController : Controller
    {
        [Route("Orders")]
        public IActionResult Index()
        {
            ViewBag.Title = "Welcome to the Orders page!";
            Order firstOrder = StaticDb.Orders.FirstOrDefault();
            OrderListViewModel ordersViewModel = new OrderListViewModel()
            {
                FirstPizza = firstOrder.Pizza.Name,
                NumberOfOrders = StaticDb.Orders.Count,
                FirstCustomerName = $"{firstOrder.User.FirstName} {firstOrder.User.LastName}",
                Orders = StaticDb.Orders
            };
            return View(ordersViewModel);
        }

        public IActionResult Details(int? id)
        {
            return View();
        }


        public IActionResult Create(string error)
        {
            ViewBag.Error = error == null ? "" : error;
            OrderViewModel model = new OrderViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(OrderViewModel model)
        {
            //First check if there is a pizza like the user entered in the form - by size and name
            Pizza pizza = StaticDb.Menu.FirstOrDefault(x => x.Name == model.PizzaName && x.Size == model.Size);

            //If there is no such pizza in the database, return an error message to the user
            if (pizza == null)
                return RedirectToAction("Create", new { error = "There is no such pizza in the menu!" });

            StaticDb.UserId++;
            User user = new User()
            {
                Id = StaticDb.UserId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                Phone = model.Phone,
            };
            StaticDb.OrderId++;
            Order order = new Order()
            {
                Id = StaticDb.OrderId,
                Delivered = false,
                Pizza = pizza,
                Price = pizza.Price + 2,
                User = user
            };

            StaticDb.Users.Add(user);
            StaticDb.Orders.Add(order);
            return View("_ThankYou");
        }
    }
}
