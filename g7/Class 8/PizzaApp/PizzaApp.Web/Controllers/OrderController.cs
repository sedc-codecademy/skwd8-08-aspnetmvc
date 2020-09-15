using Microsoft.AspNetCore.Mvc;
using PizzaApp.DataAccess.Core.Enums;
using PizzaApp.PresentationLayer.ViewModels;
using PizzaApp.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        private readonly IPizzaService _pizzaService;

        public OrderController(
            IOrderService orderService,
            IUserService userService,
            IPizzaService pizzaService)
        {
            _orderService = orderService;
            _userService = userService;
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var userOrders = _orderService.GetAllOrdersByUserId(1);

            if (userOrders == null)
            {
                userOrders = new List<OrderVM>();
            }

            return View(userOrders);
        }

        [HttpGet]
        public IActionResult PlaceOrder()
        {
            var pizzas = _pizzaService.GetPizzas();

            ViewData["Pizzas"] = pizzas.Select(p => p.Name);

            return View();
        }

        [HttpPost]
        public IActionResult PlaceOrder(OrderVM orderVm)
        {
            return RedirectToAction("Index");
        }
    }
}
