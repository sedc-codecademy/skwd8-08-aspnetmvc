using DomainModels;
using ViewModels;

namespace Mappers
{
    public static class OrderItemMapper
    {

        public static OrderItemViewModel ToViewModel(this OrderItem orderItem)
        {
            return new OrderItemViewModel
            {
                Id = orderItem.Id,
                Quantity = orderItem.Quantity,
                OrderId = orderItem.OrderId,
                PizzaSize = orderItem.PizzaSize == null ? new PizzaSizeViewModel() : orderItem.PizzaSize.ToViewModel()
            };
        }
    }
}
