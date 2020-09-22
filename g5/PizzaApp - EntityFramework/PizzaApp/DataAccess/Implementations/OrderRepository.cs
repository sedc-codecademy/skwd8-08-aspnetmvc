using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using DataAccess.Interfaces;
using DomainModels;
using Microsoft.EntityFrameworkCore;

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
            using (var db = new PizzaAppContext())
            {
                return db.Orders
                    .Include(x => x.OrderItems)
                    .ThenInclude(x => x.PizzaSize.Pizza)
                    .Include(x => x.OrderItems)
                    .ThenInclude(x => x.PizzaSize.Size)
                    .FirstOrDefault(x => x.Id == id);
            }
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
            using (var db = new PizzaAppContext())
            {
                var order = db.Orders.FirstOrDefault(x => x.Id == id);

                if (order == null)
                {
                    throw new Exception("Order not found.");
                }

                db.Remove(order);
                db.SaveChanges();
            }
        }

        public void AddOrderForCustomer(int customerId)
        {
            using (var db = new PizzaAppContext())
            {
                var customer = db.Customers.FirstOrDefault(x => x.Id == customerId);

                if(customer == null)
                    throw new Exception("Customer not found");

                Order order = new Order(customer.Id);

                db.Add(order);
                db.SaveChanges();
            }
        }
    }
}
