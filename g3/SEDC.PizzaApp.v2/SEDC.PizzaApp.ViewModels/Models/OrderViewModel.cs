using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.ViewModels.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public long Contact { get; set; }
        public List<PizzaViewModel> Pizzas { get; set; }
        public double Price { get; set; }
        public bool IsDelievered { get; set; }
    }
}
