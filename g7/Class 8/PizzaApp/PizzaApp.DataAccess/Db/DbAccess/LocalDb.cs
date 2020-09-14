using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.DataAccess.Db.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.DataAccess.Db.DbAccess
{
    public class LocalDb : IDb
    {
        public List<Pizza> SeedPizzas()
        {
            return new List<Pizza>()
            {
                new Pizza()
                {
                    ID = 1,
                    Name = "Capri",
                    Price = 10,
                    Size = Core.Enums.PizzaSize.Small
                },
                new Pizza()
                {
                    ID = 2,
                    Name = "Capri medium",
                    Price = 12,
                    Size = Core.Enums.PizzaSize.Medium
                },
                 new Pizza()
                {
                    ID = 3,
                    Name = "Capri family",
                    Price = 15,
                    Size = Core.Enums.PizzaSize.Familly
                }
            };
        }
        public List<User> SeedUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    ID = 1,
                    FirstName = "Jon",
                    LastName = "Wheyne",
                    Address = "wild west",
                    UserName = "jhonny",
                    Password = "pass1",
                    Orders = new List<Order>()
                },
                 new User()
                {
                    ID = 2,
                    FirstName = "Bruce",
                    LastName = "Wheyne",
                    Address = "ghotam",
                    UserName = "batman",
                    Password = "iamthebatman",
                    Orders = new List<Order>()
                }
            };
        }

        public List<Order> SeedOrders()
        {
            return new List<Order>()
            {
                new Order()
                {
                    ID = 1,
                    Pizzas = SeedPizzas().Take(2).ToList(),
                    User = SeedUsers().Skip(1).First()
                },
                new Order()
                {
                    ID = 2,
                    Pizzas = SeedPizzas().Take(1).ToList(),
                    User = SeedUsers().Take(1).First()
                },
            };
        }

    }
}
