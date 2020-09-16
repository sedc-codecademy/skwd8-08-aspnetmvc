using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.BusinessLayer.Interfaces;
using SEDC.PizzaApp.BusinessModels.newModels;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Application.Controllers
{
    public class OrderController : Controller
    {
        private readonly IPizzaOrderService _pizzaOrderService;

        public OrderController(IPizzaOrderService pizzaOrderService)
        {
            _pizzaOrderService = pizzaOrderService;
        }

        [HttpGet]
        public IActionResult Order(string error, int pizzas)
        {
            if(error != null)
            {
                return View("_Error");
            }

            var orderVM = new OrderViewModel();
            orderVM.Pizzas = new List<PizzaViewModelNew>();
            for (int i = 0; i < pizzas; i++)
            {
                orderVM.Pizzas.Add(new PizzaViewModelNew());
            }

            return View(orderVM);
        }

        [HttpPost]
        public IActionResult Order(OrderViewModel model)
        {
            var orderId = _pizzaOrderService.MakeNewOrder(model);

            if(orderId != 0)
            {
                return View("_ThankYou");
            }

            return RedirectToAction("Order", model);
        }
    }
}
