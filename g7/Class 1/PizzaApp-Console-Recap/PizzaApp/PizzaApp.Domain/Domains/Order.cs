using System;
using System.Collections.Generic;

namespace PizzaApp.Domain.Domains
{
    public class Order : BaseEntity
    {
        public static int OrderCount { get; set; }
        protected override int ID { get; set; } = OrderCount;
        public Order()
        {
            OrderCount++;
        }
        public IEnumerable<Pizza> Pizzas { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
