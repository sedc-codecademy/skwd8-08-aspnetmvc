using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels
{
    public class Customer
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public string Country { get; set; }

        public Customer()
        {
        }

        public Customer(string firstName, string lastName, string address, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
            Country = "Makedonija";
        }
    }
}
