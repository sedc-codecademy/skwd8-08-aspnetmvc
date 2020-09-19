using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using DataAccess.Implementations;
using DomainModels;
using Mappers;
using Services.Interfaces;
using ViewModels;

namespace Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomerService(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<CustomerViewModel> GetAll()
        {
            return _customerRepository.GetAll().Select(x => x.ToViewModel()).ToList();
        }

        public CustomerViewModel GetById(int id)
        {
            Customer customer = _customerRepository.GetById(id);

            if (customer == null)
            {
                throw new Exception($"Customer with id {id} not found");
            }

            return customer.ToViewModel();
        }

        public void Save(CustomerViewModel customerViewModel)
        {
            Customer existingCustomer = _customerRepository.GetById(customerViewModel.Id);

            if (existingCustomer == null)
            {
                Customer newCustomer = new Customer
                {
                    Id = customerViewModel.Id,
                    FirstName = customerViewModel.FirstName,
                    LastName = customerViewModel.LastName,
                    Address = customerViewModel.Address,
                    Phone = customerViewModel.Phone
                };

                _customerRepository.Insert(newCustomer);
            }
            else
            {
                existingCustomer.FirstName = customerViewModel.FirstName;
                existingCustomer.LastName = customerViewModel.LastName;
                existingCustomer.Address = customerViewModel.Address;
                existingCustomer.Phone = customerViewModel.Phone;

                _customerRepository.Update(existingCustomer);
            }
        }

        public void Delete(int id)
        {
            _customerRepository.Delete(id);
        }
    }
}
