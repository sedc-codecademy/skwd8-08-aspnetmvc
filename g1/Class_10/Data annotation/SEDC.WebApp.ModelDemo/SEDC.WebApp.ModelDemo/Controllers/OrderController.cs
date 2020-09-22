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
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index(int id, string error)
        {
           
            ViewBag.Error = error == null ? "" : error;
            return View();
        }
        [HttpPost]
        public IActionResult Index(OrderPizzaVM orderModel)
        {
            if (string.IsNullOrEmpty(orderModel.User.Address))
            {
                return RedirectToAction("Index","Order", new { id = orderModel.Pizza.Id, error = "All fields requied"});
            }
            
          
            return RedirectToAction("OrderMenu");
        }

        public IActionResult OrderMenu()
        {
            return View();
        }

        public IActionResult AllOrders()
        {
            var allOrders = _orderService.GetAllOrders();
            return View(allOrders);
        }
    }
}
