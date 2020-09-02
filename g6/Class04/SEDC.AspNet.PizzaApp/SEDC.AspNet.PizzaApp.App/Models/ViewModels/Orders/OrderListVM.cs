using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.PizzaApp.App.Models.ViewModels.Orders
{
    public class OrderListVM
    {
        public string FirstPizza { get; set; }
        public int NumberOfOrders { get; set; }
        public string FirstPersonName { get; set; }
        public List<OrderVM> Orders { get; set; }
    }
}
