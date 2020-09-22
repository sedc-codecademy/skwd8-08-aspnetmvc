using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;
using SEDC.WebApp.ModelDemo.Services.Interfaces;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private IPizzaService _pizzaService;
        private IUserService _userService;
        public OrderController(IOrderService orderService, IPizzaService pizzaService, IUserService userService)
        {
            _orderService = orderService;
            _pizzaService = pizzaService;
            _userService = userService;
        }
        public IActionResult Index(int id, string error)
        {
            ViewBag.Error = error == null ? "" : error;

            var pizza = _pizzaService.GetPizzaById(id);
            var order = new OrderPizzaVM() { Pizza = pizza };
            return View(order);
        }
        [HttpPost]
        public IActionResult Index(OrderPizzaVM orderModel)
        {
            if (string.IsNullOrEmpty(orderModel.User.Address))
            {
                return RedirectToAction("Index","Order", new { id = orderModel.Pizza.Id, error = "All fields requied"});
            }
            var pizza = _pizzaService.GetPizzaById(orderModel.Pizza.Id);
            orderModel.Pizza = pizza;
            _userService.CreateNewUser(orderModel.User);
            _orderService.CreateNewOrder(orderModel);


            return RedirectToAction("OrderMenu");
        }

        public IActionResult OrderMenu()
        {
            var orders = _orderService.GetAllOrders();
            return View(orders);
        }
    }
}
