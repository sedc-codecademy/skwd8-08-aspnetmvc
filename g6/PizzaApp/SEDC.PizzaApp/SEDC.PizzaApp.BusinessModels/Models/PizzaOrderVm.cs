using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.BusinessModels.Models
{
    public class PizzaOrderVm
    {
        public int Id { get; set; }
        public OrderVm Order { get; set; }
        public PizzaVm Pizza { get; set; }
    }
}
