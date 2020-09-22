using System.Collections.Generic;
using ViewModels;

namespace Services.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerViewModel> GetAll();
        CustomerViewModel GetById(int id);
        void Save(CustomerViewModel customerViewModel);
        void Delete(int id);
    }
}
