using SEDC.PizzaApp.BusinessModels.Models;
using SEDC.PizzaApp.BusinessModels.newModels;
using SEDC.PizzaApp.Domain.Enums;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.BusinessLayer.Interfaces
{
    public interface IPizzaOrderService
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int id);
        //void MakeNewOrder(Order order); // TODO: change to CreateOrderVM
        int MakeNewOrder(OrderViewModel orderVm);
        int GetOrderCount();
        MenuViewModelNew GetMenu();
        Order GetLastOrder();
        string GetMostPopularPizza();
        Pizza GetPizzaFromMenu(string name, PizzaSize size);
    }
}
