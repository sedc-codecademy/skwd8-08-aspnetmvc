using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Interfaces;
using DomainModels;

namespace DataAccess.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Order GetById(int id)
        {
            Customer customer = StaticDatabase.Customers.FirstOrDefault(x => x.Orders.Any(y => y.Id == id));

            if (customer == null)
            {
                throw new Exception("Customer not found");
            }

            Order order = customer.Orders.FirstOrDefault(x => x.Id == id);

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            return order;
        }

        public int Insert(Order entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            Customer customer = StaticDatabase.Customers.FirstOrDefault(x => x.Orders.Any(y => y.Id == id));

            if (customer == null)
            {
                throw new Exception("Customer not found");
            }

            Order order = customer.Orders.FirstOrDefault(x => x.Id == id);

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            int customerIndex = StaticDatabase.Customers.IndexOf(customer);

            int orderIndex = customer.Orders.IndexOf(order);
            customer.Orders.RemoveAt(orderIndex);

            StaticDatabase.Customers[customerIndex] = customer;
        }

        public void AddOrderForCustomer(int customerId)
        {
            Customer customer = StaticDatabase.Customers.FirstOrDefault(x => x.Id == customerId);

            if (customer == null)
            {
                throw new Exception("Customer not found");
            }

            int customerIndex = StaticDatabase.Customers.IndexOf(customer);

            Order order = new Order(customer.Id);
            customer.Orders.Add(order);

            StaticDatabase.Customers[customerIndex] = customer;
        }
    }
}
