using SEDC.PizzaApp.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories.CashRepositories
{
    public class OrderRepository : IRepository<Order>
    {
        public List<Order> GetAll()
        {
            return StaticDb.Orders;
        }

        public Order GetById(int id)
        {
            return StaticDb.Orders.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Order entity)
        {
            StaticDb.Orders.Add(entity);
            return entity.Id;
        }

        public void Update(Order entity)
        {
            var order = StaticDb.Orders.FirstOrDefault(x => x.Id == entity.Id);
            if (order != null)
            {
                var index = StaticDb.Orders.IndexOf(order);
                StaticDb.Orders[index] = entity;
            }
        }

        public void DeleteById(int id)
        {
            var order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if (order != null)
            {
                StaticDb.Orders.Remove(order);
            }
        }
    }
}
