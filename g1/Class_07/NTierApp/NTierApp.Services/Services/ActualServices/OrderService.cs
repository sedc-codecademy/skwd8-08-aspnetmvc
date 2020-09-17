using NTierApp.DataAccess.Core.Entities;
using NTierApp.DataAccess.Core.Interfaces;
using NTierApp.Services.Services.Interfaces;
using NTIerApp.PresentationLayer.ViewModels;
using System.Collections.Generic;

namespace NTierApp.Services.Services.ActualServices
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepo;


        public OrderService(IRepository<Order> orderRepo)
        {
            _orderRepo = orderRepo;
        }
        public bool CreateOrder(OrderVM order)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteOrder(OrderVM order)
        {
            throw new System.NotImplementedException();
        }

        public OrderVM GetOrderById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<OrderVM> GetOrders()
        {
            throw new System.NotImplementedException();
        }

        public List<OrderVM> GetOrdersByUserId(int userId)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateOrder(OrderVM order)
        {
            throw new System.NotImplementedException();
        }
    }
}
