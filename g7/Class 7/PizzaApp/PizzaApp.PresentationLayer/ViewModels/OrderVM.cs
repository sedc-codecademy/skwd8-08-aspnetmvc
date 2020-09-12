using System.Collections.Generic;

namespace PizzaApp.PresentationLayer.ViewModels
{
    public  class OrderVM
    {
        public UserVM User { get; set; }
        public List<PizzaVM> Pizzas { get; set; }
    }
}
