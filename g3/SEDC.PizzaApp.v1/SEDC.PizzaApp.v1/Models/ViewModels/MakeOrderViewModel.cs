using SEDC.PizzaApp.v1.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.v1.Models.ViewModels
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
        public string Pizzas { get; set; }

        [Display(Name = "Size: ")]
        public PizzaSize Size { get; set; }


        public List<string> PizzaNames { get; set; }
    }
}
