﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Helper;
using PizzaApp.Models.DomainModels;

namespace PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Add(int id)
        {
            Customer customer = Data.Customers.FirstOrDefault(x => x.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            int index = Data.Customers.IndexOf(customer);
            Data.Customers.RemoveAt(index);

            customer.Orders.Add(new Order());

            Data.Customers.Add(customer);
            
            return RedirectToAction("Details", "Customer", new {id});
        }

        public IActionResult Details(int id)
        {
            Customer customer = Data.Customers.FirstOrDefault(x => x.Orders.Any(x => x.Id == id));
            
            if (customer == null)
            {
                return NotFound();
            }
            
            Order order = customer.Orders.FirstOrDefault(x => x.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            return View(Order.ToViewModel(order));
        }
    }
}
