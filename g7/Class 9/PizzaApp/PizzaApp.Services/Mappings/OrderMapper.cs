using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.PresentationLayer.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.Services.Mappings
{
    public static class OrderMapper
    {
        public static List<OrderVM> MapOrdersToOrderVM(List<Order> orders)
        {
            var orderVMs = orders.Select(o => new OrderVM()
            { 
                User = UserMapper.MapUserToUserVM(o.User), 
                Pizzas = PizzaMapper.MapListOfPizzasToListPizzaVM(o.Pizzas) 
            }).ToList();

            return orderVMs;
        }

        public static List<Order> MapOrderViewModelsToOrders(List<OrderVM> orderVMs)
        {
            var orders = orderVMs.Select(ovm => new Order() 
            { 
                User = UserMapper.MapUserVMToUser(ovm.User), 
                Pizzas = PizzaMapper.MapPizzasVMsToPizzas(ovm.Pizzas) 
            }).ToList();

            return orders;
        }

        public static OrderVM MapOrderToOrderVM(Order order)
        {
            return new OrderVM()
            {
                User = UserMapper.MapUserToUserVM(order.User),
                Pizzas = PizzaMapper.MapListOfPizzasToListPizzaVM(order.Pizzas)
            };
        }

        public static Order MapOrderVMToOrder(OrderVM orderViewModel)
        {
            return new Order()
            {
                User = UserMapper.MapUserVMToUser(orderViewModel.User),
                Pizzas = PizzaMapper.MapPizzasVMsToPizzas(orderViewModel.Pizzas)
            };
        }
    }
}
