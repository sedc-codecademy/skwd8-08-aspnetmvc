using System;
using System.Collections.Generic;

namespace SEDC.AspNet.Class09.DBFirst.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderStatusId { get; set; }

        public OrderStatus OrderStatus { get; set; }
        public Users User { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }
    }
}
