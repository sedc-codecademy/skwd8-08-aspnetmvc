using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SEDC.PizzaApp.v1.Models.DomainModels;
using SEDC.PizzaApp.v1.Models.Enum;

namespace SEDC.PizzaApp.v1
{
    public static class StaticDb
    {
        public static List<User> Users { get; set; }
        public static List<Order> Orders { get; set; }
        public static List<Pizza> Menu { get; set; }

        static StaticDb()
        {
            //users
            Users = new List<User>()
            {
                new User() 
                {
                   Id = 1,
                   FirstName = "Bob",
                   LastName = "Bobsky",
                   Address = "Bob Street",
                   Phone = 02123456
                },
                new User()
                {
                   Id = 2,
                   FirstName = "Jill",
                   LastName = "Wayne",
                   Address = "Jill Street",
                   Phone = 02654321
                }
            };

            //menu
            Menu = new List<Pizza>()
            {
                new Pizza()
                {
                    Id = 1,
                    Name = "Kapri",
                    Price = 7,
                    Size = PizzaSize.Medium
                },
                new Pizza()
                {
                    Id = 2,
                    Name = "Kapri",
                    Price = 8,
                    Size = PizzaSize.Large
                },
                new Pizza()
                {
                    Id = 3,
                    Name = "Kapri",
                    Price = 9,
                    Size = PizzaSize.Family
                },
                new Pizza()
                {
                    Id = 4,
                    Name = "Peperoni",
                    Price = 9,
                    Size = PizzaSize.Medium
                },
                new Pizza()
                {
                    Id = 5,
                    Name = "Peperoni",
                    Price = 10,
                    Size = PizzaSize.Large
                },
                new Pizza()
                {
                    Id = 6,
                    Name = "Peperoni",
                    Price = 11,
                    Size = PizzaSize.Family
                },
                new Pizza()
                {
                    Id = 7,
                    Name = "Margarita",
                    Price = 6,
                    Size = PizzaSize.Medium
                },
                new Pizza()
                {
                    Id = 8,
                    Name = "Margarita",
                    Price = 7,
                    Size = PizzaSize.Large
                },
                new Pizza()
                {
                    Id = 9,
                    Name = "Margarita",
                    Price = 8,
                    Size = PizzaSize.Family
                },
                new Pizza()
                {
                    Id = 10,
                    Name = "Siciliana",
                    Price = 6.5,
                    Size = PizzaSize.Medium
                },
                new Pizza()
                {
                    Id = 11,
                    Name = "Siciliana",
                    Price = 9.5,
                    Size = PizzaSize.Large
                },
                new Pizza()
                {
                    Id = 12,
                    Name = "Siciliana",
                    Price = 9.5,
                    Size = PizzaSize.Family
                }
            };

            //orders
            Orders = new List<Order>();

            var order1 = new Order()
            {
                Id = 1,
                User = Users[0],
                Pizzas = new List<Pizza>() { Menu[0], Menu[2] },
                IsDelivered = true
            };
            order1.Price = PriceCalculator(order1.Pizzas);
            Orders.Add(order1);

            var order2 = new Order()
            {
                Id = 2,
                User = Users[0],
                Pizzas = new List<Pizza>() { Menu[3], Menu[5], Menu[7] },
                IsDelivered = true
            };
            order2.Price = PriceCalculator(order2.Pizzas);
            Orders.Add(order2);

            var order3 = new Order()
            {
                Id = 3,
                User = Users[1],
                Pizzas = new List<Pizza>() { Menu[4], Menu[6] },
                IsDelivered = false
            };
            order3.Price = PriceCalculator(order3.Pizzas);
            Orders.Add(order3);
        }

        private static double PriceCalculator(List<Pizza> pizzas) 
        {
            // 1.5 is the delievery expense
            var sum = 1.5;
            foreach (var pizza in pizzas)
            {
                sum += pizza.Price;
            }
            return sum;
        }
    }
}
