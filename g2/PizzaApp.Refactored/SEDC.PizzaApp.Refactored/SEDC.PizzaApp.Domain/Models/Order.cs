using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<PizzaOrder> PizzaOrders { get; set; } = new List<PizzaOrder>();
        public double Price 
        { 
            get
            {
                return PizzaOrders.Sum(x => x.Pizza.Price) + 2;
            } 
        }
    }
}
