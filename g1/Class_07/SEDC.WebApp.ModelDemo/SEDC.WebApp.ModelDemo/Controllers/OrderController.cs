using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.Models.Domain;
using SEDC.WebApp.ModelDemo.Models.ViewModels;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index(int id, string error)
        {
            var pizzaDomain = StaticDb.Menu.SingleOrDefault(pizza => pizza.Id == id);
            var pizzaVM = new PizzaVM()
            {
                Id = pizzaDomain.Id,
                Name = pizzaDomain.Name,
                Size = pizzaDomain.Size,
                Price = pizzaDomain.Price,
                ImageUrl = pizzaDomain.ImageUrl
            };
            var userVM = new UserVM();
            var oderVM = new OrderPizzaVM() { Pizza = pizzaVM, User = userVM };
            ViewBag.Error = error == null ? "" : error;
            return View(oderVM);
        }
        [HttpPost]
        public IActionResult Index(OrderPizzaVM orderModel)
        {
            if (string.IsNullOrEmpty(orderModel.User.Address))
            {
                return RedirectToAction("Index","Order", new { id = orderModel.Pizza.Id, error = "All fields requied"});
            }
            
            Pizza pizza = StaticDb.Menu.SingleOrDefault(p => p.Id == orderModel.Pizza.Id);
            User user = new User()
            {
                Id = StaticDb.Users.Count + 1,
                Address = orderModel.User.Address,
                FirstName = orderModel.User.FirstName,
                LastName = orderModel.User.LastName,
                Phone = orderModel.User.Phone
            };
            Order order = new Order()
            {
                Delivered = false,
                Id = StaticDb.Orders.Count + 1,
                Pizza = pizza,
                User = user
            };
            StaticDb.Users.Add(user);
            StaticDb.Orders.Add(order);
            return RedirectToAction("OrderMenu");
        }

        public IActionResult OrderMenu()
        {
            var orders = StaticDb.Orders;
            return View(orders);
        }
    }
}
