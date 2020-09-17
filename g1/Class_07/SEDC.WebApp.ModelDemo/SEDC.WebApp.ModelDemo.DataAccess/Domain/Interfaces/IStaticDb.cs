using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces
{
    public interface IStaticDb
    {
        IEnumerable<User> GetUsers();
        IEnumerable<Pizza> GetPizzas();
        IEnumerable<Order> GetOrders();
    }
}
