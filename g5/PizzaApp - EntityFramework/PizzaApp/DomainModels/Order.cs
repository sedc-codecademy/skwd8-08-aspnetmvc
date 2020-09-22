using System.Collections.Generic;

namespace DomainModels
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber => $"NO{Id}";
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public Order()
        {
        }

        public Order(int customerId)
        {
            CustomerId = customerId;
        }
    }
}
