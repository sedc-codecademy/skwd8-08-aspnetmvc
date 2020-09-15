using SEDC.MVC.BuildeingApps.DataAccess;
using SEDC.MVC.BuildingApps.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.MVC.BuildingApps.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;

        private readonly IOrderService _orderService;

        public UserService(IOrderService orderService)
        {
            _userRepository = new UserRepository();
            _orderService = orderService;
        }

        public User GetUserById(int id)
        {
            List<User> users = _userRepository.GetAll();

            User user = users.FirstOrDefault(user => user.Id == id);

            return user;
        }

        public List<string> GetUserEmails()
        {
            return _userRepository.GetAll().Select(u => $"{u.Email} {_orderService.PlaceOrder()}").ToList();
        }
    }
}
