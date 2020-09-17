using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.BusinessModels.newModels
{
    public class OrderViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
        public List<PizzaViewModelNew> Pizzas { get; set; }
    }
}
