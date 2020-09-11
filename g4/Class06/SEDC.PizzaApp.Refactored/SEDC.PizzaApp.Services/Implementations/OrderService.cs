using System;
using System.Collections.Generic;
using System.Text;
using SEDC.PizzaApp.DataAccess;
using SEDC.PizzaApp.DataAccess.Implementations;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Mappers.Order;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.Order;

namespace SEDC.PizzaApp.Services.Implementations
{
    public class OrderService : IOrderService
    {
        //only used by the service for its logic
        private IRepository<Order> _orderRepository;

        public OrderService()
        {
            //implementation of the IRepository<Order> interface
            _orderRepository = new OrderRepository();
        }
        public List<OrderDetailsViewModel> GetAllOrders()
        {
            //call to data access layer
            List<Order> orders = _orderRepository.GetAll();
            List<OrderDetailsViewModel> viewModels = new List<OrderDetailsViewModel>();
            foreach (Order order in orders)
            {
                viewModels.Add(order.ToOrderDetailsViewModel());
            }

            return viewModels;
        }
    }
}
