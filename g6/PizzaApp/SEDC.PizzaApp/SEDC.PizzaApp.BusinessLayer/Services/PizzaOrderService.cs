using SEDC.PizzaApp.BusinessLayer.Interfaces;
using SEDC.PizzaApp.BusinessModels.newModels;
using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.Domain.Enums;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.BusinessLayer.Services
{
    public class PizzaOrderService : IPizzaOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Pizza> _pizzaRepository;

        public PizzaOrderService(IRepository<Order> orderRepository,
            IRepository<Pizza> pizzaRepository)
        {
            _orderRepository = orderRepository;
            _pizzaRepository = pizzaRepository;
        }

        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAll(); // TODO: create mapping to orderVM
        }

        public Order GetLastOrder()
        {
            var orders = _orderRepository.GetAll();
            return orders[orders.Count - 1];
        }

        //public List<Pizza> GetMenu()
        //{
        //    var menu = _pizzaRepository.GetAll()
        //        .GroupBy(p => p.Name)
        //        .Select(x => x.First())
        //        .ToList();
        //    return menu;
        //}

        public MenuViewModelNew GetMenu()
        {
            var menu = _pizzaRepository.GetAll()
                .GroupBy(p => p.Name)
                .Select(x => x.First())
                .ToList();

            List<PizzaViewModelNew> listOfPizzas = new List<PizzaViewModelNew>();
            foreach (var piza in menu)
            {
                listOfPizzas.Add(new PizzaViewModelNew
                {
                    Id = piza.Id,
                    Image = piza.Image,
                    Name = piza.Name,
                    Price = piza.Price,
                    Size = piza.Size
                });
            }
            var model = new MenuViewModelNew
            {
                Menu = listOfPizzas
            };

            return model;
        }

        public string GetMostPopularPizza()
        {
            var orders = _orderRepository.GetAll();

            var pizzas = orders
                .SelectMany(x => x.PizzaOrders)
                .ToList();

            var mostPopularPizza = pizzas
                .GroupBy(x => x.Pizza.Name)
                .OrderByDescending(x => x.Count())
                .FirstOrDefault()
                .Select(x => x.Pizza.Name)
                .FirstOrDefault();

            return mostPopularPizza;
        }

        public Order GetOrderById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public int GetOrderCount()
        {
            return _orderRepository.GetAll().Count;
        }

        public Pizza GetPizzaFromMenu(string name, PizzaSize size)
        {
            return _pizzaRepository.GetAll().FirstOrDefault(p => p.Name == name && p.Size == size);
        }

        public void MakeNewOrder(Order order)
        {
            // TODO: make validations and map to order
            _orderRepository.Insert(order);
        }

        public int MakeNewOrder(OrderViewModel orderVm)
        {
            var order = new Order();
            var pizzas = new List<PizzaOrder>();

            foreach (var pizzaVm in orderVm.Pizzas)
            {
                var pizzaOrder = new PizzaOrder()
                {
                    Pizza = GetPizzaFromMenu(pizzaVm.Name, pizzaVm.Size),
                    Order = order
                };
                pizzaOrder.PizzaId = pizzaOrder.Pizza.Id;
                pizzas.Add(pizzaOrder);
            }

            var user = new User
            {
                Address = orderVm.Address,
                FirstName = orderVm.FirstName,
                LastName = orderVm.LastName,
                Phone = orderVm.Phone
            };

            order.PizzaOrders = pizzas;
            order.User = user;
            return _orderRepository.Insert(order);
        }
    }
}
