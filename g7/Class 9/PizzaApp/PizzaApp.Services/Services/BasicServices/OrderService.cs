using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.DataAccess.Repositorties.Interfaces;
using PizzaApp.PresentationLayer.ViewModels;
using PizzaApp.Services.Exceptions;
using PizzaApp.Services.Mappings;
using PizzaApp.Services.Services.Interfaces;
using System.Collections.Generic;

namespace PizzaApp.Services.Services.BasicServices
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepo;
        private readonly IRepository<User> _userRepo;

        public OrderService(IRepository<Order> orderRepo, IRepository<User> userRepo)
        {
            _orderRepo = orderRepo;
            _userRepo = userRepo;
        }

        public List<OrderVM> GetAllOrders()
        {
            var orders = _orderRepo.GetAll();
            var ordersViewModelList = OrderMapper.MapOrdersToOrderVM(orders);

            return ordersViewModelList;
        }

        public List<OrderVM> GetAllOrdersByUserId(int userId)
        {
            var user = _userRepo.GetById(userId);

            if (user == null)
            {
                throw new UserNotFoundException("User with thad Id doesn't exist.");
            }

            var userOrders = user.Orders;
            var userOrdersViewModelList = OrderMapper.MapOrdersToOrderVM(userOrders);

            return userOrdersViewModelList;
        }

        public OrderVM GetOrderById(int orderId)
        {
            var order = _orderRepo.GetById(orderId);
            var orderViewModel = OrderMapper.MapOrderToOrderVM(order);

            return orderViewModel;
        }

        public Order AddOrder(OrderVM orderViewModel)
        {
            var order = OrderMapper.MapOrderVMToOrder(orderViewModel);

            bool isOrderAdded = _orderRepo.Save(order);

            if (!isOrderAdded)
            {
                throw new OrderNotAddedException("Order can not be added.");
            }

            return order;
        }

        public Order UpdateOrder(OrderVM orderViewModel)
        {
            var order = OrderMapper.MapOrderVMToOrder(orderViewModel);

            bool isOrderUpdated = _orderRepo.Edit(order);

            if (!isOrderUpdated)
            {
                throw new OrderNotUpdatedException("Order can not be updated.");
            }

            return order;
        }

        public bool DeleteOrder(OrderVM order)
        {
            return _orderRepo.Delete(OrderMapper.MapOrderVMToOrder(order));
        }
    }
}
