using System;
using System.Collections.Generic;
using System.Linq;
using DomainModels;

namespace DataAccess.Implementations
{
    public class PizzaRepository : IRepository<Pizza>
    {
        public List<Pizza> GetAll()
        {
            using (var db = new PizzaAppContext())
            {
                return db.Pizzas.ToList();
            }
        }

        public Pizza GetById(int id)
        {
            using (var db = new PizzaAppContext())
            {
                return db.Pizzas.FirstOrDefault(x => x.Id == id);
            }
        }

        public int Insert(Pizza entity)
        {
            using (var db = new PizzaAppContext())
            {
                db.Add(entity);
                db.SaveChanges();
                return entity.Id;
            }
        }

        public void Update(Pizza entity)
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
                var pizza = db.Pizzas.FirstOrDefault(x => x.Id == id);

                if(pizza == null)
                    throw new Exception("Pizza not found.");

                db.Remove(pizza);
                db.SaveChanges();
            }
        }
    }
}
