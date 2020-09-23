using Microsoft.EntityFrameworkCore;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories.EntityRepositories
{
    public class OrderEntityRepository : IRepository<Order>
    {

        private PizzaDbContext _context;
        public OrderEntityRepository(PizzaDbContext context)
        {
            _context = context;
        }


        public List<Order> GetAll()
        {
            List<Order> allOrders = _context.Orders
                                    .Include(x => x.PizzaOrders)
                                    .ThenInclude(x => x.Pizza)
                                    .Include(x => x.User)
                                    .ToList();
            return allOrders;
        }

        public Order GetById(int id)
        {
            return _context.Orders
                           .Include(x => x.User)
                           .SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Order entity)
        {
            _context.Orders.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public void Update(Order entity)
        {
            Order order = _context.Orders.SingleOrDefault(x => x.Id == entity.Id);
            if (order != null)
            {
                entity.Id = order.Id;
                _context.Orders.Update(entity);
            }
        }

        public void DeleteById(int id)
        {
            Order order = _context.Orders.SingleOrDefault(x => x.Id == id);
            if (order != null)
                _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }
}
