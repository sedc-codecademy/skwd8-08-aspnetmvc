using PizzaApp.Domain.Enums;
using System.Collections.Generic;

namespace PizzaApp.Domain.Domains
{
    public class User : BaseEntity
    {
        public static int UsersCount { get; set; }
        public User()
        {
            UsersCount++;
        }
        protected override int ID { get; set; } = UsersCount;
        public string  Name { get; set; }
        public string LastName { get; set; }
        public UserCredentials UserCredentials { get; set; }
        public UserRole Role { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
