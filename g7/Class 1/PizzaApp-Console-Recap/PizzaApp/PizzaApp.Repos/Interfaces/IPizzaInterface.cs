using PizzaApp.Domain.Domains;
using PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;

namespace PizzaApp.Service.Interfaces
{
    interface IPizzaInterface
    {
        Pizza GetPizzaById(int id);
        List<Pizza> GetPizzasByType(PizzaType type);

        List<Pizza> GetPizzasByOrderId(int orderId);

        List<Pizza> GetPizzasByOrderDate(DateTime orderDate);
    }
}
