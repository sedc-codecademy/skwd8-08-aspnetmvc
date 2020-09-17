using SEDC.PizzaApp.BusinessLayer.Interfaces;
using SEDC.PizzaApp.BusinessModels.Models;
using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public string GetLastUsername()
        {
            return _userRepository.GetAll().LastOrDefault().FirstName;
        }

        public UserVm GetUserById(int id)
        {
            var user = _userRepository.GetById(id);

            var userVm = new UserVm
            {
                Address = user.Address,
                Id = user.Id,
                LastName = user.LastName,
                Phone = user.Phone,
                FirstName = user.FirstName
            };

            var listOfOrders = new List<OrderVm>();
            foreach (var order in user.Orders)
            {
                var orderVm = MapOrderToOrderVm(order, userVm);
                listOfOrders.Add(orderVm);
            }
            userVm.Orders = listOfOrders;

            //userVm.Orders = user.Orders.Select(o => MapOrderToOrderVm(o, userVm)).ToList();

            return userVm;
        }

        private OrderVm MapOrderToOrderVm(Order order, UserVm user)
        {
            return new OrderVm
            {
                Id = order.Id,
                User = user,
                PizzaOrders = order.PizzaOrders.Select(x => MapPizzaOrderToPizzaOrderVm(x, user)).ToList()
            };
        }

        private PizzaOrderVm MapPizzaOrderToPizzaOrderVm(PizzaOrder order, UserVm user)
        {
            return new PizzaOrderVm
            {
                Id = order.Id,
                Order = new OrderVm
                {
                    Id = order.Order.Id,
                    User = user
                },
                Pizza = new PizzaVm
                {
                    Id = order.Pizza.Id,
                    Image = order.Pizza.Image,
                    Name = order.Pizza.Name,
                    Price = order.Pizza.Price,
                    Size = order.Pizza.Size
                }
            };
        }
    }
}
