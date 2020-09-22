using System;
using System.Collections.Generic;
using System.Linq;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Implementations
{
    public class OrderItemRepository : IRepository<OrderItem>
    {
        public List<OrderItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderItem GetById(int id)
        {
            using (var db = new PizzaAppContext())
            {
                //return db.OrderItems
                //    .Include(x => x.PizzaSize)
                //    .ThenInclude(x => x.Pizza)
                //    .Include(x => x.PizzaSize)
                //    .ThenInclude(x => x.Size)
                //    .FirstOrDefault(x => x.Id == id);

                return db.OrderItems
                    .Include(x => x.PizzaSize.Pizza)
                    .Include(x => x.PizzaSize.Size)
                    .FirstOrDefault(x => x.Id == id);
            }
        }

        public int Insert(OrderItem entity)
        {
            using (var db = new PizzaAppContext())
            {
                db.Add(entity);
                db.SaveChanges();
                return entity.Id;
            }
        }

        public void Update(OrderItem entity)
        {
            using (var db = new PizzaAppContext())
            {
                db.Update(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new PizzaAppContext())
            {
                var orderItem = db.OrderItems.FirstOrDefault(x => x.Id == id);

                if(orderItem == null) 
                    throw new Exception("Order Item does not exist");

                db.Remove(orderItem);
                db.SaveChanges();
            }
        }
    }
}
