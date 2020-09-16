using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories.CacheRepositories
{
    public class OrderRepository : IRepository<Order>
    {

        public List<Order> GetAll()
        {
            return CacheDb.Orders;
        }

        public Order GetById(int id)
        {
            return CacheDb.Orders.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Order entity)
        {
            CacheDb.OrderId++;
            entity.Id = CacheDb.OrderId;
            CacheDb.Orders.Add(entity);
            return entity.Id;
        }

        public void Update(Order entity)
        {
            Order order = CacheDb.Orders.SingleOrDefault(x => x.Id == entity.Id);
            if(order != null)
            {
                int index = CacheDb.Orders.IndexOf(order);
                CacheDb.Orders[index] = entity;
            }
        }

        public void DeleteById(int id)
        {
            Order order = CacheDb.Orders.SingleOrDefault(x => x.Id == id);
            if (order != null)
                CacheDb.Orders.Remove(order);
        }
    }
}
