using Microsoft.EntityFrameworkCore;
using SEDC.WebApp.ModelDemo.DataAccess.DB;
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
        private PizzaDbContext _db;
        public OrderRepository(PizzaDbContext db)
        {
            _db = db;
        }
        public int Create(Order entity)
        {
            var orderModel = _db.Orders.SingleOrDefault(order => order.Id == entity.Id);
            if (orderModel != null) return -1;
            _db.Orders.Add(entity);
            return _db.SaveChanges();
        }

        public int Delete(int id)
        {
            var orderModel = _db.Orders.SingleOrDefault(order => order.Id == id);
            if (orderModel == null) return -1;
            _db.Orders.Remove(orderModel);
            return _db.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return _db.Orders
                .Include(order => order.Pizza)
                .Include(order => order.User)
                .ToList();
        }

        public Order GetById(int id)
        {
            return _db.Orders
                .Include(order => order.Pizza)
                // .ThenInclude(pizza => pizza.Discount)
                .Include(order => order.User)
                .SingleOrDefault(order => order.Id == id);
        }

        public int Update(Order entity)
        {
            var orderModel = _db.Orders.SingleOrDefault(order => order.Id == entity.Id);
            if (orderModel == null) return -1;
            _db.Orders.Update(entity);
            return _db.SaveChanges();
        }
    }
}
