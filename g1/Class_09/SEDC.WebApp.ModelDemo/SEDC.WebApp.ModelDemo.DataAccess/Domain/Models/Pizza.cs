using SEDC.WebApp.ModelDemo.DataAccess.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.WebApp.ModelDemo.DataAccess.Domain.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSize Size { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public Discount Discount { get; set; }
    }
}
