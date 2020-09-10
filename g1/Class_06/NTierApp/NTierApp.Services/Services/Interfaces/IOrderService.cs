using NTierApp.DataAccess.Core.Entities;
using NTIerApp.PresentationLayer.ViewModels;
using System.Collections.Generic;

namespace NTierApp.Services.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderVM> GetOrders();
        OrderVM GetOrderById(int id);
        bool CreateOrder(OrderVM order);
        bool UpdateOrder(OrderVM order);
        bool DeleteOrder(OrderVM order);
        List<OrderVM> GetOrdersByUserId(int userId);
    }
}
