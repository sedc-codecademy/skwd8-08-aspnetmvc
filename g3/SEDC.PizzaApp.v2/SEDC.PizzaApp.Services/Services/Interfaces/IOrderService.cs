using SEDC.PizzaApp.DomainModels.Models;
using SEDC.PizzaApp.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderViewModel> GetAllOrders();
        string GetFirstPizzaName();
        string GetFirstPerson();
        int GetTotalNumberOfOrders();
        string GetMostPopularPizza();
        OrderViewModel GetOrderById(int id);
        void FinishOrder(int id);
        void CreateOrder(Order order);
    }
}
