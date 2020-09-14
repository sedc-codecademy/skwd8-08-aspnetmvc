using SEDC.PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.BusinessModels.Models
{
    public class PizzaVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSize Size { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public List<PizzaOrderVm> PizzaOrders { get; set; }
    }
}
