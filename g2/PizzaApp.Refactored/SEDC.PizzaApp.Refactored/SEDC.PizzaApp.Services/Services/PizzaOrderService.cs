using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.CacheRepositories;
using SEDC.PizzaApp.Domain.Enums;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Services
{
    public class PizzaOrderService : IPizzaOrderService
    {
        private IRepository<Pizza> _pizzaRepository;
        private IRepository<Order> _orderRepository;
        public PizzaOrderService()
        {
            _pizzaRepository = new PizzaRepository();
            _orderRepository = new OrderRepository();
        }

        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public Order GetLastOrder()
        {
            return _orderRepository.GetAll().LastOrDefault();
        }

        public List<Pizza> GetMenu()
        {
            List<Pizza> menu = _pizzaRepository.GetAll()
                .GroupBy(x => x.Name)
                .Select(x => x.First())
                .ToList();
            return menu;
        }

        public string GetMostPopularPizza()
        {
            List<Order> orders = _orderRepository.GetAll();

            List<PizzaOrder> pizzas = orders
                .SelectMany(x => x.PizzaOrders)
                .ToList();

            string mostPopularPizza = pizzas
                .GroupBy(x => x.Pizza.Name)        // First we group pizzas by name like 2 pepperoni, 10 kapri, 15 margarita, 1 siciliana
                .OrderByDescending(x => x.Count()) // Sort them by descending order by their appearance
                .FirstOrDefault()                  // Take the first pizza, which is the most ordered
                .Select(x => x.Pizza.Name)         // Select the name from that pizza
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
            return _pizzaRepository.GetAll().Where(x => x.Name == name && x.PizzaSize == size).FirstOrDefault();
        }

        public void MakeNewOrder(Order order)
        {
            //Validation
            _orderRepository.Insert(order);
        }
    }
}
