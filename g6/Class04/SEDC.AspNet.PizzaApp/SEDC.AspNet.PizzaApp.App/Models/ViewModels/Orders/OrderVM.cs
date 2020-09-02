using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.PizzaApp.App.Models.ViewModels.Orders
{
    public class OrderVM
    {
        public int Id { get; set; }
        public PizzaVM Pizza { get; set; }
        public double Price { get; set; }
        public UserVM User { get; set; }
        public bool Delivered { get; set; }
    }
}
