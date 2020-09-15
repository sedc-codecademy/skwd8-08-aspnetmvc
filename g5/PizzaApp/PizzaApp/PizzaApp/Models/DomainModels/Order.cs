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

        public Order(int customerId)
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
            OrderNumber = $"NO{Id}";
            OrderItems = new List<OrderItem>();
            CustomerId = customerId;
        }

        public static OrderViewModel ToViewModel(Order order)
        {
            //return new OrderViewModel
            //{
            //    Id = order.Id,
            //    OrderNumber = order.OrderNumber,
            //    CustomerId = order.CustomerId,
            //    OrderItems = order.OrderItems.Select(x => OrderItem.ToViewModel(x)).ToList()
            //};

            OrderViewModel orderViewModel = new OrderViewModel
            {
                Id = order.Id,
                OrderNumber = order.OrderNumber,
                CustomerId = order.CustomerId,
                OrderItems = new List<OrderItemViewModel>()
            };

            foreach (var item in order.OrderItems)
            {
                orderViewModel.OrderItems.Add(OrderItem.ToViewModel(item));
            }

            return orderViewModel;
        }
    }
}
