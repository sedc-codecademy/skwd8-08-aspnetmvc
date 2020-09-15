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
                var orderVm = new OrderVm
                {
                    Id = order.Id,
                    User = userVm,
                    PizzaOrders = order.PizzaOrders.Select(x => new PizzaOrderVm
                    {
                        Order = new OrderVm
                        {
                            Id = x.Order.Id,
                            User = userVm
                        },
                        Pizza = new PizzaVm
                        {
                            Id = x.Pizza.Id,
                            Image = x.Pizza.Image,
                            Name = x.Pizza.Name,
                            Price = x.Pizza.Price,
                            Size = x.Pizza.Size
                        }
                    }).ToList()
                };
            }

            userVm.Orders = listOfOrders;

            return userVm;
        }
    }
}
