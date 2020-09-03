using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.v1.Models.Enum;

namespace SEDC.PizzaApp.v1.Models.DomainModels
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public PizzaSize Size { get; set; }
    }
}
