using ViewModels;

namespace Services.Interfaces
{
    public interface IOrderService
    {
        OrderViewModel GetById(int id);
        void Delete(int id);
        void AddOrderForCustomer(int customerId);
    }
}
