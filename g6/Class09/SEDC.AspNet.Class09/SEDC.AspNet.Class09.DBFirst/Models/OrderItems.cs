using System;
using System.Collections.Generic;

namespace SEDC.AspNet.Class09.DBFirst.Models
{
    public partial class OrderItems
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantaty { get; set; }

        public Orders Order { get; set; }
        public Products Product { get; set; }
    }
}
