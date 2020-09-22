using System;
using System.Collections.Generic;

namespace DomainModels
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int CustomerId { get; set; }

        public Order(int customerId)
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
            OrderNumber = $"NO{Id}";
            OrderItems = new List<OrderItem>();
            CustomerId = customerId;
        }
    }
}
