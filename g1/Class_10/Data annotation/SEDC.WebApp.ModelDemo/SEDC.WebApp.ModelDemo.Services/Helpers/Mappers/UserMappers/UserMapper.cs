using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;
using SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.OrderMappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.UserMappers
{
    public static class UserMapper
    {
        public static User UserVMtoUser(UserVM model)
        {
            return new User()
            {
                Address = model.Address,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Phone = model.Phone,
                //Orders = OrderMapper.OrdersVMtoOrders(model.Orders)
            };
        }

        public static UserVM UserToUserVM(User model)
        {
            return new UserVM()
            {
                Address = model.Address,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Phone = model.Phone,
                //Orders = OrderMapper.OrdersToOrdersVM(model.Orders)
            };
        }

        public static List<User> UsersVMtoUsers(List<UserVM> models)
        {
            return models.Select(userVM => new User()
            {
                Address = userVM.Address,
                FirstName = userVM.FirstName,
                LastName = userVM.LastName,
                Phone = userVM.Phone,
                //Orders = OrderMapper.OrdersVMtoOrders(userVM.Orders)
            }).ToList();

            // return models.Select(pizzaVM=> PizzaVMtoPizza(pizzaVM))

        }

        public static List<UserVM> UsersToUsersVM(List<User> models)
        {

            return models.Select(user => new UserVM()
            {
                Address = user.Address,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                //Orders = OrderMapper.OrdersToOrdersVM(user.Orders)
            }).ToList();

            // return models.Select(order=> PizzaToPizzaVM(order))

        }
    }
}
