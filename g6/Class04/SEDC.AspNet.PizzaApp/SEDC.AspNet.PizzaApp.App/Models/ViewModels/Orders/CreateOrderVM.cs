using SEDC.AspNet.PizzaApp.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.PizzaApp.App.Models.ViewModels.Orders
{
    public class CreateOrderVM
    {
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "Address for dilivery")]
        public string Address { get; set; }
        public long Phone { get; set; }
        [Display(Name = "Type of pizza")]
        public string PizzaName { get; set; }
        public PizzaSize Size { get; set; }
    }
}
