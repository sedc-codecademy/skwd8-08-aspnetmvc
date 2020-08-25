using PizzaApp.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Services.Interfaces
{
    public interface IUserService
    {
        User GetUserById(List<User> users, int id);
        User GetusersByOrderId(int orderId);
        IEnumerable<User> GetUsersByOrderDate(DateTime orderDate);
    }
}
