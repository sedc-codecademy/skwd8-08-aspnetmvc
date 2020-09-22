using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        public List<OrderViewModel> Orders { get; set; }

        public CustomerViewModel()
        {
            Orders = new List<OrderViewModel>();
        }
    }
}
