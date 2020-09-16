using SEDC.PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Domain.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public List<PizzaOrder> PizzaOrders { get; set; }
    }
}
