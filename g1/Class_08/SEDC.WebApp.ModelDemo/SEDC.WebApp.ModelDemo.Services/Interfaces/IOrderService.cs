using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderPizzaVM> GetAllOrders();
        OrderPizzaVM GetOrderById(int id);
        string CreateNewOrder(OrderPizzaVM model);
        string DeleteExistingOrder(int id);
    }
}
