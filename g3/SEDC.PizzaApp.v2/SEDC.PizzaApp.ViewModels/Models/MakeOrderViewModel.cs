using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SEDC.PizzaApp.ViewModels.Models
{
    public class MakeOrderViewModel
    {
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }

        [Display(Name = "Address: ")]
        public string Address { get; set; }

        [Display(Name = "Phone: ")]
        public long Phone { get; set; }

        [Display(Name = "Type of pizza: ")]
        public List<PizzaViewModel> Pizzas { get; set; }

        public List<string> PizzaNames { get; set; }
    }
}
