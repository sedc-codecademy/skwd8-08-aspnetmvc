using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    public class OrderController : Controller
    {
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
    }
}
