using SEDC.PizzaApp.v1.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.v1.Models.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public long Contact { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public double Price { get; set; }
        public bool IsDelievered { get; set; }
    }
}
