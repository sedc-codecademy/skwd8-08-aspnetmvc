using System;
using System.Collections.Generic;
using System.Linq;
using DomainModels;

namespace DataAccess.Implementations
{
    public class CustomerRepository : IRepository<Customer>
    {
        public List<Customer> GetAll()
        {
            return StaticDatabase.Customers;
        }

        public Customer GetById(int id)
        {
            return StaticDatabase.Customers.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Customer entity)
        {
            StaticDatabase.Customers.Add(entity);
            return entity.Id;
        }

        public void Update(Customer entity)
        {
            Customer customer = StaticDatabase.Customers.FirstOrDefault(x => x.Id == entity.Id);
            if (customer == null)
            {
                throw new Exception($"Customer with id {entity.Id} was not found");
            }
            //update the record in DB
            int index = StaticDatabase.Customers.IndexOf(customer);
            StaticDatabase.Customers[index] = entity;
        }

        public void Delete(int id)
        {
            Customer customer = StaticDatabase.Customers.FirstOrDefault(x => x.Id == id);
            if (customer == null)
            {
                throw new Exception($"Customer with id {id} was not found");
            }
            //delete record from DB
            int index = StaticDatabase.Customers.IndexOf(customer);
            StaticDatabase.Customers.RemoveAt(index);
        }
    }
}
