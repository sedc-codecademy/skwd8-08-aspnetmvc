using System;
using System.Collections.Generic;

namespace SEDC.AspNet.Class09.DBFirst.Models
{
    public partial class Users
    {
        public Users()
        {
            Orders = new HashSet<Orders>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }

        public ICollection<Orders> Orders { get; set; }
        public ICollection<UserRoles> UserRoles { get; set; }
    }
}
