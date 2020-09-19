using System.Linq;
using ViewModels;
using DomainModels;

namespace Mappers
{
    public static class OrderMapper
    {

        public static OrderViewModel ToViewModel(this Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                OrderNumber = order.OrderNumber,
                CustomerId = order.CustomerId,
                OrderItems = order.OrderItems.Select(x => x.ToViewModel()).ToList()
            };
        }
    }
}
