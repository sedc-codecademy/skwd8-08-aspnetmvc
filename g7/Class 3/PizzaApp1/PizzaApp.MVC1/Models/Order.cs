using System;

namespace PizzaApp.MVC1.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public Pizza Pizza { get; set; }
    }
}
