using PizzaApp.Domain.Domains;
using PizzaApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.Repos
{
    public class UserRepository : IUser
    {
        public User GetUserById(List<User> users,int id)
        {
            //var user = users.SingleOrDefault(u => u.)
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
