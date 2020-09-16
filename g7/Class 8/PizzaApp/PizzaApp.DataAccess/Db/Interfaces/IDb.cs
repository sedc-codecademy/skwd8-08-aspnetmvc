using PizzaApp.DataAccess.Core.Entities;
using System.Collections.Generic;

namespace PizzaApp.DataAccess.Db.Interfaces
{
    public interface IDb
    {
        List<Pizza> SeedPizzas();
        List<User> SeedUsers();
        List<Order> SeedOrders();
    }
}
