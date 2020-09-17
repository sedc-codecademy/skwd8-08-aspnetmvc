using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.WebApp.ModelDemo.DataAccess.ViewModels
{
    public class OrderPizzaVM
    {
        public bool Delivered { get; set; }
        public UserVM User { get; set; }
        public PizzaVM Pizza { get; set; }
    }
}
