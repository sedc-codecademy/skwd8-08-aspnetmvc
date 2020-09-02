using Microsoft.AspNetCore.Mvc;
using SEDC.AspNet.PizzaApp.App.InMemoryDatabase;
using SEDC.AspNet.PizzaApp.App.Models.Domain;
using SEDC.AspNet.PizzaApp.App.Models.ViewModels;
using SEDC.AspNet.PizzaApp.App.Models.ViewModels.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.PizzaApp.App.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("Orders")]
        public IActionResult Index()
        {
            Order firstOrder = Database.Orders.FirstOrDefault();

            var listOfOrderVM = new List<OrderVM>();
            foreach (var order in Database.Orders)
            {
                var orderVM1 = new OrderVM()
                {
                    Id = order.Id,
                    Delivered = order.Delivered,
                    Pizza = new PizzaVM
                    {
                        Id = order.Pizza.Id,
                        Name = order.Pizza.Name,
                        Price = order.Pizza.Price,
                        Size = order.Pizza.Size
                    },
                    Price = order.Price,
                    User = new UserVM
                    {
                        Id = order.User.Id,
                        Address = order.User.Address,
                        FirstName = order.User.FirstName,
                        LastName = order.User.LastName,
                        Phone = order.User.Phone
                    }
                };

                listOfOrderVM.Add(orderVM1);
            }

            OrderListVM orderVM = new OrderListVM
            {
                FirstPersonName = $"{firstOrder.User.FirstName} {firstOrder.User.LastName}",
                NumberOfOrders = Database.Orders.Count,
                FirstPizza = firstOrder.Pizza.Name,
                Orders = listOfOrderVM
            };

            ViewBag.Title = "Welcome to the Orders page!";

            return View("Orders", orderVM);
        }

        [HttpGet("CreateOrder")]
        public IActionResult CreateOrder(string error)
        {
            ViewBag.Error = error;
            return View();
        }

        [HttpPost("CreateOrder")]
        public IActionResult CreateOrder(CreateOrderVM createOrder)
        {
            var pizza = Database.Menu.FirstOrDefault(p => p.Name == createOrder.PizzaName && p.Size == createOrder.Size);

            // some error handling
            if(pizza == null)
            {
                return RedirectToAction("CreateOrder", new { error = "There is no pizza like that in the menu" });
            }

            var user = new User()
            {
                Id = Database.Users.Count + 1,
                FirstName = createOrder.FirstName,
                LastName = createOrder.LastName,
                Address = createOrder.Address,
                Phone = createOrder.Phone
            };

            var order = new Order
            {
                Id = Database.Orders.Count + 1,
                Delivered = false,
                Price = pizza.Price + 2,
                Pizza = pizza,
                User = user
            };

            Database.Orders.Add(order);
            Database.Users.Add(user);

            return View("OrderComplete");
        }
    }
}
