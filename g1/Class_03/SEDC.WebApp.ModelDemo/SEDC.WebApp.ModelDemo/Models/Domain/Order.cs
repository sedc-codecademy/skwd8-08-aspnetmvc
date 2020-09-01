using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.WebApp.ModelDemo.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public bool Delivered { get; set; }
        public User User { get; set; }
        public Pizza Pizza { get; set; }
    }
}
