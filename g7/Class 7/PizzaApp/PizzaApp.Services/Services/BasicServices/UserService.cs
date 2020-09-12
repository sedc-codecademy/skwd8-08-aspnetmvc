using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.PresentationLayer.ViewModels;
using PizzaApp.Services.Services.Interfaces;
using System.Collections.Generic;

namespace PizzaApp.Services.Services.BasicServices
{
    public class UserService : IUserService
    {
        public List<UserVM> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }
        public UserVM GetUserById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<UserVM> GetUsersByMostOrders(List<OrderVM> orders)
        {
            throw new System.NotImplementedException();
        }
        public User AddUser(UserVM user)
        {
            throw new System.NotImplementedException();
        }

        public User UpdateUser(UserVM user)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteUser(UserVM user)
        {
            throw new System.NotImplementedException();
        }
    }
}
