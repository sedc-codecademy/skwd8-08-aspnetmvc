using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.DataAccess.Repositorties.Interfaces;
using PizzaApp.PresentationLayer.ViewModels;
using PizzaApp.Services.Exceptions;
using PizzaApp.Services.Mappings;
using PizzaApp.Services.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.Services.Services.BasicServices
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepo;

        public UserService(IRepository<User> userRepo)
        {
            _userRepo = userRepo;
        }

        public List<UserVM> GetAllUsers()
        {
            var users = _userRepo.GetAll();
            var usersViewModel = UserMapper.MapUsersToUserVM(users);

            return usersViewModel;
        }
        public UserVM GetUserById(int id)
        {
            var user = _userRepo.GetById(id);
            var userViewModel = UserMapper.MapUserToUserVM(user);

            return userViewModel;
        }

        public List<UserVM> GetUsersWithDiscount(List<UserVM> orders)
        {
            var usersWithDiscount = _userRepo.GetAll().Where(u => u.Orders.Count >= 20).ToList();
            var usersWithDiscountViewModel = UserMapper.MapUsersToUserVM(usersWithDiscount);

            return usersWithDiscountViewModel;
        }

        public User AddUser(UserVM userViewModel)
        {
            var user = UserMapper.MapUserVMToUser(userViewModel);
            bool userExists = _userRepo.GetAll().Contains(user);

            if (userExists)
            {
                throw new UserAlreadyExistsException("User already exists.");
            }

            _userRepo.Save(user);

            return user;
        }

        public User UpdateUser(UserVM userViewModel)
        {
            var user = UserMapper.MapUserVMToUser(userViewModel);

            _userRepo.Edit(user);

            return user;
        }

        public bool DeleteUser(UserVM userViewModel)
        {
            var user = UserMapper.MapUserVMToUser(userViewModel);

            return _userRepo.Delete(user);
        }
    }
}
