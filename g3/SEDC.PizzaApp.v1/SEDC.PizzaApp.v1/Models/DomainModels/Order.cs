using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.v1.Models.DomainModels
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
