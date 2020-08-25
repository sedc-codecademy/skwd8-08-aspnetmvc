using PizzaApp.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Domain.SeedEntities
{
    public static class SeedUsersAndPizzas
    {
        public static List<User> SeedUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    Name = "Damjan",
                    LastName = "Stojanovski",
                    Role = Enums.UserRole.standardUser,
                    Orders = new List<Order>(),
                    UserCredentials = new UserCredentials(){Username="damjan",Password = "pass1234"}
                },
                new User()
                {
                    Name = "Ivan",
                    LastName = "Trajchev",
                    Role = Enums.UserRole.Admin,
                    Orders = new List<Order>(),
                    UserCredentials = new UserCredentials(){Username = "Ivan", Password = "notValid"}
                }
            };
        }

        public static List<Pizza> SeedPizzas()
        {
            return new List<Pizza>()
            {
                new Pizza()
                {
                    Type = Enums.PizzaType.Margaritha,
                    Price = 9,
                    Size = Enums.PizzaSize.Small
                },
                new Pizza()
                {
                    Type = Enums.PizzaType.Capri,
                    Price = 10,
                    Size = Enums.PizzaSize.Medium
                },
                new Pizza()
                {
                    Type = Enums.PizzaType.Funghi,
                    Price = 12,
                    Size = Enums.PizzaSize.Large
                }

            };
        }
    }
}
