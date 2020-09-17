using DomainModels;
using ViewModels;

namespace Mappers
{
    public static class CustomerMapper
    {
        public static CustomerViewModel ToViewModel(this Customer customer)
        {
            return new CustomerViewModel
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Address = customer.Address,
                Phone = customer.Phone
            };
        }


    }
}
