using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Services.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.Models;

namespace SEDC.PizzaApp.WebApp.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult Orders() {

            var orders = _orderService.GetAllOrders();
            var firstPizza = _orderService.GetFirstPizzaName();
            var firstPersonName = _orderService.GetFirstPerson();
            var numberOfOrder = _orderService.GetTotalNumberOfOrders();
            var mostPopulatPizza = _orderService.GetMostPopularPizza();

            var ordersViewModel = new OrdersViewModel()
            {
                Orders = orders,
                FirstPersonName = firstPersonName,
                FirstPizza = firstPizza,
                NumberOfOrders = numberOfOrder,
                MostPopularPizza = mostPopulatPizza
            };

            return View(ordersViewModel);
        }
    }
}
