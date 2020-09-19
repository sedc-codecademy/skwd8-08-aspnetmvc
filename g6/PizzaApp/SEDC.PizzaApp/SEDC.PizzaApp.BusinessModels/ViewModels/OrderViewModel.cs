using System.Collections.Generic;

namespace SEDC.PizzaApp.BusinessModels.ViewModels
{
    public class OrderViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
        public List<PizzaViewModel> Pizzas { get; set; }
    }
}
