using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Class03.App.Models.ViewModels
{
    public class CreateUserVM
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Phone")]
        public long Phone { get; set; }
        [Display(Name = "Current address(street name)")]
        public string Address { get; set; }
        [Display(Name = "Do you like to subscribe to our newsletter?")]
        public bool IsSubscribed { get; set; }
    }
}
