using SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;
using SEDC.WebApp.ModelDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Services
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepository;
        public OrderService(IRepository<Order> orderRepo)
        {
            _orderRepository = orderRepo;
        }

        public string CreateNewOrder(OrderPizzaVM model)
        {
            throw new NotImplementedException();
        }

        public string DeleteExistingOrder(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderPizzaVM> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public OrderPizzaVM GetOrderById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
