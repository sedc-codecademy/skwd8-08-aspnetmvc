using PizzaApp.Domain.Domains;
using System;
using System.Collections.Generic;

namespace PizzaApp.Service.Interfaces
{
    interface IUser
    {
        User GetUserById(List<User> users,int id);
        User GetusersByOrderId(int orderId);
        IEnumerable<User> GetUsersByOrderDate(DateTime orderDate);
    }
}
