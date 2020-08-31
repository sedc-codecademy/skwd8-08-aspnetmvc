using PizzaApp.Domain.Domains;
using System;
using System.Collections.Generic;

namespace PizzaApp.Services
{
    public class UserRepo
    {
        public User GetUserById(List<User> users, int id)
        {
            
            return new User();
        }

        public IEnumerable<User> GetUsersByOrderDate(DateTime orderDate)
        {
            throw new NotImplementedException();
        }

        public User GetusersByOrderId(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
