using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.Models.DomainModels
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int TotalPrice => OrderItems.Sum(x => x.Quantity * x.PizzaSize.Price);
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
