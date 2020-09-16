using SEDC.PizzaApp.v1.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.v1.Models.ViewModels
{
    public class PizzaViewModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public PizzaSize Size { get; set; }
    }
}
