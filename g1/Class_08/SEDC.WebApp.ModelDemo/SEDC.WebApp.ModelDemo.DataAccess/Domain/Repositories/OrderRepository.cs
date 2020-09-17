using SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.WebApp.ModelDemo.DataAccess.Domain.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private IStaticDb _db;
        public OrderRepository(IStaticDb db)
        {
            _db = db;
        }
        public int Create(Order entity)
        {
            var orderModel = _db.GetOrders().SingleOrDefault(order => order.Id == entity.Id);
            if (orderModel != null) return -1;
            _db.GetOrders().ToList().Add(entity);
            return 1;
        }

        public int Delete(int id)
        {
            var orderModel = _db.GetOrders().SingleOrDefault(order => order.Id == id);
            if (orderModel == null) return -1;
            _db.GetOrders().ToList().Remove(orderModel);
            return 1;
        }

        public List<Order> GetAll()
        {
            return _db.GetOrders().ToList();
        }

        public Order GetById(int id)
        {
            return _db.GetOrders().SingleOrDefault(order => order.Id == id);
        }

        public int Update(Order entity)
        {
            var orderModel = _db.GetOrders().SingleOrDefault(order => order.Id == entity.Id);
            if (orderModel == null) return -1;
            int orderIndex = _db.GetOrders().ToList().IndexOf(orderModel);
            _db.GetOrders().ToList()[orderIndex] = entity;
            return 1;
        }
    }
}
