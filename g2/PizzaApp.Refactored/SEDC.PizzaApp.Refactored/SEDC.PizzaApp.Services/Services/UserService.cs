using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.CacheRepositories;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public int AddNewUser(User entity)
        {
            return _userRepository.Insert(entity);
        }

        public string GetLastUserName()
        {
            return _userRepository.GetAll().LastOrDefault().FirstName;
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }
    }
}
