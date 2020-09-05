using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.v1.Models.DomainModels;

namespace SEDC.PizzaApp.v1.Models.ViewModels
{
    public class OrdersViewModel
    {
        public string FirstPersonName { get; set; }
        public string FirstPizza { get; set; }
        public int NumberOfOrders { get; set; }
        public List<OrderViewModel> Orders { get; set; }
    }
}
