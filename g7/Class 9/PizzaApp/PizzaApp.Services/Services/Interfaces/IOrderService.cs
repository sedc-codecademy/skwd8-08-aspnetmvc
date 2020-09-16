using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.PresentationLayer.ViewModels;
using System.Collections.Generic;

namespace PizzaApp.Services.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderVM> GetAllOrders();
        List<OrderVM> GetAllOrdersByUserId(int userId);
        OrderVM GetOrderById(int orderId);
        Order AddOrder(OrderVM order);
        Order UpdateOrder(OrderVM order);
        bool DeleteOrder(OrderVM order);

    }
}
