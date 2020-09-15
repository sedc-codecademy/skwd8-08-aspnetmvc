using System;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Models.DomainModels
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int PizzaSizeId { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }

        public OrderItem(int orderId)
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
            OrderId = orderId;
        }

        public OrderItem(PizzaSize pizzaSize, int quantity, int orderId)
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
            PizzaSizeId = pizzaSize.Id;
            PizzaSize = pizzaSize;
            Quantity = quantity;
            OrderId = orderId;
        }

        public static OrderItemViewModel ToViewModel(OrderItem orderItem)
        {
            return new OrderItemViewModel
            {
                Id = orderItem.Id,
                Quantity = orderItem.Quantity,
                OrderId = orderItem.OrderId,
                PizzaSize = orderItem.PizzaSize == null ? new PizzaSizeViewModel() : PizzaSize.ToViewModel(orderItem.PizzaSize)
            };
        }
    }
}
