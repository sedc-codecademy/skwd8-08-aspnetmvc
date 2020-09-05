using SEDC.WebApp.ModelDemo.Models.Domain;
using SEDC.WebApp.ModelDemo.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.WebApp.ModelDemo
{
    public static class StaticDb 
    {
        public static List<Order> Orders;
        public static List<Pizza> Menu;
        public static List<User> Users;
        static StaticDb()
        {
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Address = "Bob Street",
                    Phone = 080012312345
                }
            };
            Menu = new List<Pizza>()
            {
                new Pizza()
                {
                    Id = 1,
                    Name = "Kapri",
                    Price = 7,
                    Size = PizzaSize.Small,
                    ImageUrl="https://www.abeautifulplate.com/wp-content/uploads/2015/08/the-best-homemade-margherita-pizza-1-4-480x480.jpg"
                },
                new Pizza()
                {
                    Id = 2,
                    Name = "Kapri",
                    Price = 8,
                    Size = PizzaSize.Medium,
                    ImageUrl="https://www.abeautifulplate.com/wp-content/uploads/2015/08/the-best-homemade-margherita-pizza-1-4-480x480.jpg"
                },
                new Pizza()
                {
                    Id = 3,
                    Name = "Kapri",
                    Price = 9,
                    Size = PizzaSize.Family,
                    ImageUrl="https://www.abeautifulplate.com/wp-content/uploads/2015/08/the-best-homemade-margherita-pizza-1-4-480x480.jpg"
                }
            };
            Orders = new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    User = Users[0],
                    Pizza = Menu[0],
                    Delivered = false
                }
            };
        }
    }
}
