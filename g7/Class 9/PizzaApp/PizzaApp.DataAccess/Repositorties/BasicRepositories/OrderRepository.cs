using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.DataAccess.Db.Interfaces;
using PizzaApp.DataAccess.Repositorties.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.DataAccess.Repositorties.BasicRepositories
{
    public class OrderRepository : IRepository<Order>
    {
        private IDb _db;
        public OrderRepository(IDb db)
        {
            _db = db;
        }
        public List<Order> GetAll()
        {
            return _db.SeedOrders();
        }

        public Order GetById(int id)
        {
            Order order = _db.SeedOrders().SingleOrDefault(o => o.ID == id);
            if (order == null)
            {
                throw new ApplicationException("The order does not extist");
            }
            return order;
        }

        public bool Save(Order entity)
        {
            Order order = _db.SeedOrders().SingleOrDefault(o => o.ID == entity.ID);
            if (order != null)
            {
                throw new ApplicationException("The order  extist");
            }
            _db.SeedOrders().Add(order);
            return true;
        }

        public bool Edit(Order entity)
        {
            Order order = _db.SeedOrders().SingleOrDefault(o => o.ID == entity.ID);
            if (order == null)
            {
                throw new ApplicationException("The order does not extist");
            }
            order.Pizzas = entity.Pizzas;
            order.User = entity.User;
            _db.SeedOrders().Add(order);
            return true;
        }

        public bool Delete(Order entity)
        {
            Order order = _db.SeedOrders().SingleOrDefault(o => o.ID == entity.ID);
            if (order == null)
            {
                throw new ApplicationException("The order does not extist");
            }
            _db.SeedOrders().Remove(order);
            return true;
        }
    }
}
