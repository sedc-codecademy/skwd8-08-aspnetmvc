using System;
using System.Collections.Generic;

namespace SEDC.AspNet.Class09.DBFirst.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            Orders = new HashSet<Orders>();
        }

        public int OrderStatusId { get; set; }
        public byte Status { get; set; }
        public int ChangedBy { get; set; }
        public DateTime LastChange { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
