using NTierApp.DataAccess.Core.Entities;
using NTierApp.DataAccess.Core.Interfaces;
using NTierApp.Services.Services.Interfaces;
using NTIerApp.PresentationLayer.ViewModels;
using System.Collections.Generic;

namespace NTierApp.Services.Services.ActualServices
{
    public class UserService : IUserService
    {

        private IRepository<User> _userRepo;


        public UserService(IRepository<User> userRepo)
        {
            _userRepo = userRepo;
        }
        public bool CreateUser(UserVM user)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteUser(UserVM user)
        {
            throw new System.NotImplementedException();
        }

        public List<UserVM> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public UserVM GetUserById(int id)
        {
            throw new System.NotImplementedException();
        }

        public UserVM GetUserWithMostOrders(List<User> users)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateUser(UserVM user)
        {
            throw new System.NotImplementedException();
        }
    }
}
