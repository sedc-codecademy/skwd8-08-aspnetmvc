using System.Collections.Generic;

namespace PizzaApp.DataAccess.Core.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public User User { get; set; }
        public List<Pizza> Pizzas { get; set; }
    }
}
