using System.Collections.Generic;
using System.Linq;

namespace ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItemViewModel> OrderItems { get; set; }
        public int Total => OrderItems.Sum(x => x.Quantity * x.PizzaSize.Price);
    }
}
