using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.BusinessModels.newModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Application.Controllers
{
    public class OrderController : Controller
    {
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
    }
}
