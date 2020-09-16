using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.PresentationLayer.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.Services.Mappings
{
    public static class UserMapper
    {
        public static List<UserVM> MapUsersToUserVM(List<User> users)
        {
            var userViewModelList = users.Select(u => new UserVM() 
            { 
                FirstName = u.FirstName, 
                LastName = u.LastName, 
                Address = u.Address, 
                Password = u.Password, 
                UserName = u.UserName, 
                Orders = OrderMapper.MapOrdersToOrderVM(u.Orders) 
            }).ToList();

            return userViewModelList;
        }

        public static UserVM MapUserToUserVM(User user)
        {
            return new UserVM()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Address = user.Address,
                Password = user.Password,
                Orders = OrderMapper.MapOrdersToOrderVM(user.Orders)
            };
        }

        public static User MapUserVMToUser(UserVM userVM)
        {
            return new User()
            {
                FirstName = userVM.FirstName,
                LastName = userVM.LastName,
                UserName = userVM.UserName,
                Address = userVM.Address,
                Password = userVM.Password,
                Orders = new List<Order>(),
            };
        }
    }
}
