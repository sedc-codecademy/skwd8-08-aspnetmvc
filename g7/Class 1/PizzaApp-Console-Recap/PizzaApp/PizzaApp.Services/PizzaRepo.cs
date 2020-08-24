using PizzaApp.Domain.Domains;
using PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.Services
{
    public class PizzaRepo
    {
        public Pizza GetPizzaById(List<Pizza> pizzas,int id)
        {
            var pizza = pizzas.SingleOrDefault(p => id == Pizza.PizzasCount);
            if (pizza == null)
            {
                throw new Exception("Pizza is not foubd");
            }
            return pizza;
        }

        public List<Pizza> GetPizzasByOrderDate(List<Order> orders, DateTime orderDate)
        {
            var ordersFiltered = orders.Where(o => o.OrderDate == orderDate);
            if (!ordersFiltered.Any())
            {
                Console.WriteLine("No such orders on that date");
            }
            var pizzasForOrder = new List<Pizza>();
            foreach (var order in ordersFiltered)
            {
                foreach (var pizza in order.Pizzas)
                {
                    pizzasForOrder.Add(pizza);
                }
            }
            return pizzasForOrder;
        }

        public List<Pizza> GetPizzasByOrderId(List<Order> orders, int orderId)
        {
            var pizzas = orders.SingleOrDefault(o => Order.OrderCount == orderId).Pizzas.ToList();
            if (pizzas == null)
            {
                Console.WriteLine("There are no pizzas there");
            }
            return pizzas;
        }

        public List<Pizza> GetPizzasByType(List<Pizza> pizzas, PizzaType type)
        {
            var pizzasList = pizzas.Where(p => p.Type == type ).ToList();

            if (pizzasList == null)
            {
                Console.WriteLine("No such pizza types");
            }
            return pizzasList;
        }
    }
}
