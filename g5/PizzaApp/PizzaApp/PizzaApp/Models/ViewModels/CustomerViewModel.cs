using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaApp.Models.ViewModels
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

        public CustomerViewModel()
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
        }
    }
}
