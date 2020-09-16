
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Enums;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.WebApp.ModelDemo.DataAccess
{
    public class StaticDb : IStaticDb
    {
            public IEnumerable<User> GetUsers()
            {
            return new List<User>()
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
        }
        public IEnumerable<Pizza> GetPizzas() 
        { 
            return new List<Pizza>()
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
        }
        public IEnumerable<Order> GetOrders() 
        { 
            return new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    User = GetUsers().ToList()[0],
                    Pizza = GetPizzas().ToList()[0],
                    Delivered = false
                }
            };
        }
    } 
}
