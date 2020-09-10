using System;
using System.Collections.Generic;
using System.Linq;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Models.DomainModels
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        //public int TotalPrice => OrderItems.Sum(x => x.Quantity * x.PizzaSize.Price);
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public Order()
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
            OrderNumber = $"NO{Id}";
        }

        public static OrderViewModel ToViewModel(Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                OrderNumber = order.OrderNumber
            };
        }
    }
}
