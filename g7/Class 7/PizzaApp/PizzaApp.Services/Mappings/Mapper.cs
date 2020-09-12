using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.PresentationLayer.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.Services.Mappings
{
    public static class Mapper
    {
        public static List<PizzaVM> MapListOfPizzasToListPizzaVM(List<Pizza> pizzas)
        {
            var vms = pizzas.Select(p => new PizzaVM() { Name = p.Name, Price = p.Price, Size = p.Size }).ToList();
            return vms;
        }

        public static List<Pizza> MapPizzasVMsToPizzas(List<PizzaVM> pizzasVMS)
        {
            var pizzas = pizzasVMS.Select(pvm => new Pizza() { Name = pvm.Name, Price = pvm.Price, Size = pvm.Size }).ToList();
            return pizzas;
        }

        public static PizzaVM MapPizzaToPizzaVM(Pizza pizza)
        {
            return new PizzaVM()
            {
                Name = pizza.Name,
                Price = pizza.Price,
                Size = pizza.Size
            };
        }

        public static Pizza MapPizzaVMToPizza(PizzaVM pizzaVM)
        {
            return new Pizza()
            {
                Name = pizzaVM.Name,
                Price = pizzaVM.Price,
                Size = pizzaVM.Size
            };
        }

        public static List<UserVM> MapUsersToUserVM(List<User> users)
        {
            var userViewModelList = users.Select(u => new UserVM() { FirstName = u.FirstName, LastName = u.LastName, Address = u.Address, Password = u.Password, UserName = u.UserName, Orders = MapOrdersToOrderVM(u.Orders) }).ToList();
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
                Orders = MapOrdersToOrderVM(user.Orders)
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

        public static List<OrderVM> MapOrdersToOrderVM(List<Order> orders)
        {
            var orderVMs = orders.Select(o => new OrderVM() { User = MapUserToUserVM(o.User), Pizzas = MapListOfPizzasToListPizzaVM(o.Pizzas) }).ToList();
            return orderVMs;
        }

        public static List<Order> MapOrderViewModelsToOrders(List<OrderVM> orderVMs)
        {
            var orders = orderVMs.Select(ovm => new Order() { User = MapUserVMToUser(ovm.User), Pizzas = MapPizzasVMsToPizzas(ovm.Pizzas) }).ToList();
            return orders;
        }

        public static OrderVM MapOrderToOrderVM(Order order)
        {
            return new OrderVM()
            {
                User = MapUserToUserVM(order.User),
                Pizzas = MapListOfPizzasToListPizzaVM(order.Pizzas)
            };
        }
        
    }
}
