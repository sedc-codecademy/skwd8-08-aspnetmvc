using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.DomainModels.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public double Price { get; set; }
        public User User { get; set; }
        public bool IsDelivered { get; set; }
    }
}
