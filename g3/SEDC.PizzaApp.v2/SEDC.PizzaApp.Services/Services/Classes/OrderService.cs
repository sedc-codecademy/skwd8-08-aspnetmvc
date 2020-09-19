using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DomainModels.Models;
using SEDC.PizzaApp.Services.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Services.Classes
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepository;

        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<OrderViewModel> GetAllOrders()
        {
            var dbOrders = _orderRepository.GetAll();

            var orders = new List<OrderViewModel>();

            foreach (var order in dbOrders)
            {
                var tempOrder = new OrderViewModel()
                {
                    Id = order.Id,
                    FullName = order.User.FirstName + " " + order.User.LastName,
                    Address = order.User.Address,
                    Contact = order.User.Phone,
                    Price = order.Price,
                    IsDelievered = order.IsDelivered,
                    Pizzas = new List<PizzaViewModel>()
                };

                foreach (var pizza in order.Pizzas)
                {
                    var tempPizza = new PizzaViewModel()
                    {
                        Name = pizza.Name,
                        Price = pizza.Price,
                        Size = pizza.Size
                    };

                    tempOrder.Pizzas.Add(tempPizza);
                }

                orders.Add(tempOrder);
            }

            return orders;
        }

        public string GetFirstPizzaName()
        {
            return _orderRepository.GetAll().First().Pizzas[0].Name;
        }

        public string GetFirstPerson()
        {
            var firstName = _orderRepository.GetAll().First().User.FirstName;
            var lastName = _orderRepository.GetAll().First().User.LastName;
            return $"{firstName} {lastName}";
        }

        public int GetTotalNumberOfOrders()
        {
            return _orderRepository.GetAll().Count;
        }

        public string GetMostPopularPizza()
        {
            // we get all orders
            var orders = _orderRepository.GetAll();

            // flattening (list of all pizzas from all order)
            var pizzas = orders
                .SelectMany(x => x.Pizzas)
                .ToList();

            var mostPopularPizza = pizzas
                .GroupBy(x => x.Name)
                .OrderByDescending(x => x.Count())
                .FirstOrDefault()
                .Select(x => x.Name)
                .FirstOrDefault();

            return mostPopularPizza;
        }

        public OrderViewModel GetOrderById(int id)
        {
            var dbOrder = _orderRepository.GetById(id);

            var orderViewModel = new OrderViewModel()
            {
                Id = dbOrder.Id,
                FullName = dbOrder.User.FirstName + " " + dbOrder.User.LastName,
                Address = dbOrder.User.Address,
                Contact = dbOrder.User.Phone,
                Price = dbOrder.Price,
                IsDelievered = dbOrder.IsDelivered,
                Pizzas = new List<PizzaViewModel>()
            };

            foreach (var pizza in dbOrder.Pizzas)
            {
                var tempPizza = new PizzaViewModel()
                {
                    Name = pizza.Name,
                    Price = pizza.Price,
                    Size = pizza.Size
                };

                orderViewModel.Pizzas.Add(tempPizza);
            }

            return orderViewModel;
        }

        public void FinishOrder(int id)
        {
            var dbOrder = _orderRepository.GetById(id);
            dbOrder.IsDelivered = true;
            _orderRepository.Update(dbOrder);
        }

        public void CreateOrder(Order order)
        {
            order.Id = _orderRepository.GetAll().Last().Id + 1;
            _orderRepository.Insert(order);
        }
    }
}
