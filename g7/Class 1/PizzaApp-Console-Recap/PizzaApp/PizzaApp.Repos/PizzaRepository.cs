using PizzaApp.Domain.Domains;
using PizzaApp.Domain.Enums;
using PizzaApp.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace PizzaApp.Repos
{
    public class PizzaRepository : IPizzaInterface
    {
        public Pizza GetPizzaById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetPizzasByOrderDate(DateTime orderDate)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetPizzasByOrderId(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetPizzasByType(PizzaType type)
        {
            throw new NotImplementedException();
        }
    }
}
