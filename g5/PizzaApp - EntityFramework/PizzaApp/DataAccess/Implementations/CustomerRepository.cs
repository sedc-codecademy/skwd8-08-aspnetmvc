using System;
using System.Collections.Generic;
using System.Linq;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Implementations
{
    public class CustomerRepository : IRepository<Customer>
    {
        public List<Customer> GetAll()
        {
            using (var db = new PizzaAppContext())
            {
                return db.Customers.Include(x => x.Orders).ThenInclude(x => x.OrderItems).ToList();
            }
        }

        public Customer GetById(int id)
        {
            using (var db = new PizzaAppContext())
            {
                return db.Customers.Include(x => x.Orders).ThenInclude(x => x.OrderItems).FirstOrDefault(x => x.Id == id);
            }
        }

        public int Insert(Customer entity)
        {
            using (var db = new PizzaAppContext())
            {
                db.Customers.Add(entity);
                db.SaveChanges();
                return entity.Id;
            }
        }

        public void Update(Customer entity)
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
                var customer = db.Customers.FirstOrDefault(x => x.Id == id);

                if (customer == null)
                    throw new Exception("Customer not found.");

                db.Remove(customer);
                db.SaveChanges();
            }
        }

        ////ExecuteQuery("Capri")
        ////ExecuteQuery("Capri';Drop Database PizzaDb;--")
        //public void ExecuteQuery(string name)
        //{
        //    using (var db = new PizzaAppContext())
        //    {
        //        db.Database.ExecuteSqlRaw($"Select * From Pizzas Where Name Like {name}");

        //        var t = $"Select * From Pizzas Where Name Like 'Capri';Drop Database PizzaDb;--'";


        //        db.Database.ExecuteSqlRaw("Select * From Pizzas Where Name Like {0}", name);
        //    }
        //}
    }
}
