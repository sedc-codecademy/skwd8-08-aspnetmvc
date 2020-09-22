using System;
using System.Linq;
using DataAccess;
using DataAccess.Interfaces;
using DomainModels;
using Mappers;
using Services.Interfaces;
using ViewModels;

namespace Services.Implementations
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IRepository<OrderItem> _orderItemRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IRepository<PizzaSize> _pizzaSizeRepository;

        public OrderItemService(IRepository<OrderItem> orderItemRepository, 
            IOrderRepository orderRepository, 
            IRepository<PizzaSize> pizzaSizeRepository)
        {
            _orderItemRepository = orderItemRepository;
            _orderRepository = orderRepository;
            _pizzaSizeRepository = pizzaSizeRepository;
        }

        public OrderItemViewModel CreateNewOrderItem(int orderId)
        {
            var order = _orderRepository.GetById(orderId);

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            OrderItem orderItem = new OrderItem(order.Id);

            return orderItem.ToViewModel();
        }

        public void Save(OrderItemViewModel orderItem)
        {
            var order = _orderRepository.GetById(orderItem.OrderId);

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            var pizzaSize = _pizzaSizeRepository.GetById(orderItem.PizzaSizeId);

            if (pizzaSize == null)
            {
                throw new Exception("Pizza size not found");
            }

            OrderItem existingOrderItemForSamePizza = order.OrderItems.FirstOrDefault(x => x.PizzaSizeId == orderItem.PizzaSizeId);

            if (existingOrderItemForSamePizza != null)
            {
                existingOrderItemForSamePizza.Quantity += orderItem.Quantity;
                _orderItemRepository.Update(existingOrderItemForSamePizza);
            }
            else
            {
                OrderItem newOrderItem = new OrderItem(pizzaSize, orderItem.Quantity, order.Id);
                _orderItemRepository.Insert(newOrderItem);
            }
        }

        public void Delete(int id)
        {
            _orderItemRepository.Delete(id);
        }

        public OrderItemViewModel GetById(int id)
        {
            var orderItem = _orderItemRepository.GetById(id);
            return orderItem.ToViewModel();
        }
    }
}
