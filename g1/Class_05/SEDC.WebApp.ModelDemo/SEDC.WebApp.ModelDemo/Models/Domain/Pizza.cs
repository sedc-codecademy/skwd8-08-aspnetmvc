using SEDC.WebApp.ModelDemo.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.WebApp.ModelDemo.Models.Domain
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSize Size { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
