using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.ViewModels.Models
{
    public class OrdersViewModel
    {
        public string FirstPersonName { get; set; }
        public string FirstPizza { get; set; }
        public int NumberOfOrders { get; set; }
        public string MostPopularPizza { get; set; }
        public List<OrderViewModel> Orders { get; set; }
    }
}
