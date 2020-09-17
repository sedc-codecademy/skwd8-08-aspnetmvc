using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;
using SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.PizzaMappers;
using SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.UserMappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.OrderMappers
{
    public static class OrderMapper
    {
        public static Order OrderVMtoOrder(OrderPizzaVM model)
        {
            return new Order()
            {
                Delivered = model.Delivered,
                Pizza = PizzaMapper.PizzaVMtoPizza(model.Pizza),
                User = UserMapper.UserVMtoUser(model.User)
            };
        }

        public static OrderPizzaVM OrderToOrderVM (Order model)
        {
            return new OrderPizzaVM()
            {
                Delivered = model.Delivered,
                Pizza = PizzaMapper.PizzaToPizzaVM(model.Pizza),
                User = UserMapper.UserToUserVM(model.User)
            };
        }

        public static List<Order> OrdersVMtoOrders(List<OrderPizzaVM> models)
        {

            return models.Select(orderVM => new Order()
            {
                Delivered = orderVM.Delivered,
                Pizza = PizzaMapper.PizzaVMtoPizza(orderVM.Pizza),
                User = UserMapper.UserVMtoUser(orderVM.User)
            }).ToList();

            // return models.Select(order=> OrderVMtoOrder(order))

        }

        public static List<OrderPizzaVM> OrdersToOrdersVM(List<Order> models)
        {

            return models.Select(order => new OrderPizzaVM()
            {
                Delivered = order.Delivered,
                Pizza = PizzaMapper.PizzaToPizzaVM(order.Pizza),
                User = UserMapper.UserToUserVM(order.User)
            }).ToList();

            // return models.Select(order=> OrderToOrderVM(order))

        }
    }
}
