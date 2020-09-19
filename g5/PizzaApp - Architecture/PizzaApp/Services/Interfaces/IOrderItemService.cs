using ViewModels;

namespace Services.Interfaces
{
    public interface IOrderItemService
    {
        OrderItemViewModel CreateNewOrderItem(int orderId);
        void Save(OrderItemViewModel orderItem);
        void Delete(int id);
        OrderItemViewModel GetById(int id);
    }
}
