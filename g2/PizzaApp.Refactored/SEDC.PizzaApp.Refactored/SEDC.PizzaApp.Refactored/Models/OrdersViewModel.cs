using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Refactored.Models
{
    public class OrdersViewModel
    {
        public int OrderCount { get; set; }
        public string LastPizza { get; set; }
        public string MostPopularPizza { get; set; }
        public string NameOfFirstCustomer { get; set; }
        public List<OrderItemViewModel> Orders { get; set; }
    }
}
