using DataAccess;
using DataAccess.Interfaces;
using DomainModels;
using Mappers;
using Services.Interfaces;
using ViewModels;

namespace Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public OrderViewModel GetById(int id)
        {
            return _orderRepository.GetById(id).ToViewModel();
        }

        public void Delete(int id)
        {
            _orderRepository.Delete(id);
        }

        public void AddOrderForCustomer(int customerId)
        {
            _orderRepository.AddOrderForCustomer(customerId);
        }
    }
}
