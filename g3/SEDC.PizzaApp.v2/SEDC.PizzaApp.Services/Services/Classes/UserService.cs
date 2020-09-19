using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DomainModels.Models;
using SEDC.PizzaApp.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Services.Classes
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepostory;

        public UserService(IRepository<User> userRepostory)
        {
            _userRepostory = userRepostory;
        }

        public void AddUser(User user) 
        {
            user.Id = _userRepostory.GetAll().Last().Id + 1;
            _userRepostory.Insert(user);
        }

    }
}
