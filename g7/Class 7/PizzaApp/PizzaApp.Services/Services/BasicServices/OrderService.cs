using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.PresentationLayer.ViewModels;
using PizzaApp.Services.Services.Interfaces;
using System.Collections.Generic;

namespace PizzaApp.Services.Services.BasicServices
{
    public class OrderService : IOrderService
    {
        public List<OrderVM> GetAllOrders()
        {
            throw new System.NotImplementedException();
        }

        public List<OrderVM> GetAllOrdersByUserId(int userId)
        {
            throw new System.NotImplementedException();
        }

        public OrderVM GetOrderById(int orderId)
        {
            throw new System.NotImplementedException();
        }

        public Order AddOrder(OrderVM order)
        {
            throw new System.NotImplementedException();
        }

        public Order UpdateOrder(OrderVM order)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteOrder(OrderVM order)
        {
            throw new System.NotImplementedException();
        }
    }
}
