using SEDC.PizzaApp.DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.ViewModels.Models
{
    public class AddPizzaViewModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public PizzaSize Size { get; set; }
    }
}
