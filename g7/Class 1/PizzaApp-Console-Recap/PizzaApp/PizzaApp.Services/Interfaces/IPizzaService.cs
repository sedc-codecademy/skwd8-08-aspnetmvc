using PizzaApp.Domain.Domains;
using PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Services.Interfaces
{
    interface IPizzaService
    {
        Pizza GetPizzaById(List<Pizza> pizzas,int id);
        List<Pizza> GetPizzasByType(List<Pizza> pizzas, PizzaType type);

        List<Pizza> GetPizzasByOrderId(List<Order> orders, int orderId);

        List<Pizza> GetPizzasByOrderDate(List<Pizza> pizzas, DateTime orderDate);
    }
}
