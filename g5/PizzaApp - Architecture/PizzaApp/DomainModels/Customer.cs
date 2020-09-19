using System;
using System.Collections.Generic;

namespace DomainModels
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Order> Orders { get; set; }

        public Customer()
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
            Orders = new List<Order>();
        }

        public Customer(string firstName, string lastName, string address, string phone)
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
            Orders = new List<Order>();
        }
    }
}
