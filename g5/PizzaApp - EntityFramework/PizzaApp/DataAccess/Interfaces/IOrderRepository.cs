using DomainModels;

namespace DataAccess.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        void AddOrderForCustomer(int customerId);
    }
}
