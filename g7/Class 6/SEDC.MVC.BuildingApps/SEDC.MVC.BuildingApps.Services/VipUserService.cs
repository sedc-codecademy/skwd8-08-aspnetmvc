using SEDC.MVC.BuildeingApps.DataAccess;
using SEDC.MVC.BuildingApps.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.MVC.BuildingApps.Services
{
    public class VipUserService : IUserService
    {
        private readonly UserRepository _userRepository;

        public VipUserService()
        {
            _userRepository = new UserRepository();
        }

        public User GetUserById(int id)
        {
            List<User> users = _userRepository.GetAll();

            User user = users.FirstOrDefault(user => user.Id == id);

            return user;
        }

        public List<string> GetUserEmails()
        {
            return _userRepository.GetAll().Select(u => $"VIP User: {u.Email}").ToList();
        }
    }
}
