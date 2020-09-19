using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.DomainModels.Models;
using SEDC.PizzaApp.Services.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.Models;

namespace SEDC.PizzaApp.WebApp.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private IMenuService _menuService;
        private IUserService _userService;

        public OrderController(IOrderService orderService, 
                               IMenuService menuService,
                               IUserService userService)
        {
            _orderService = orderService;
            _menuService = menuService;
            _userService = userService;
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

        [HttpGet]
        public IActionResult Details(int id) 
        {
            var order = _orderService.GetOrderById(id);

            if (order == null) return RedirectToAction("Index");

            return View(order);
        }

        [HttpGet]
        public IActionResult CompleteOrder(int id) 
        {
            _orderService.FinishOrder(id);
            return RedirectToAction("Details", new { id = id });
        }


        [HttpGet]
        public IActionResult Order(string error, int? pizzas) 
        {
            var menu = _menuService.GetMenu();

            var pizzaNames = new List<string>();

            foreach (var pizza in menu)
            {
                pizzaNames.Add(pizza.Name);
            }

            var filteredPizzaNames = pizzaNames.Distinct().ToList();

            var viewModel = new MakeOrderViewModel()
            {
                PizzaNames = filteredPizzaNames,
                Pizzas = new List<PizzaViewModel>()
            };

            for (int i = 0; i < pizzas; i++)
            {
                viewModel.Pizzas.Add(new PizzaViewModel());
            }

            ViewBag.Error = error;

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Order(MakeOrderViewModel model)
        {
            try
            {
                var user = new User()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    Phone = model.Phone
                };

                _userService.AddUser(user);

                var order = new Order()
                {
                    IsDelivered = false,
                    Price = 1.5,
                    User = user,
                    Pizzas = new List<Pizza>()
                };

                foreach (var pizza in model.Pizzas)
                {
                    var tempPizza = _menuService.GetPizzaByNameAndSize(pizza.Name, pizza.Size);
                    order.Price += tempPizza.Price;
                    order.Pizzas.Add(tempPizza);
                }

                _orderService.CreateOrder(order);

                return View("_ThankYou");
            }
            catch (Exception ex)
            {
                var message = "We dont have selected pizza/s at this moment, please select another one.";
                return RedirectToAction("Order", "Order", new { error = message, pizzas = model.Pizzas.Count });
            }
        }

    }
}
