using System;
using System.Collections.Generic;
using System.Linq;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Implementations
{
    public class PizzaSizeRepository : IRepository<PizzaSize>
    {
        public List<PizzaSize> GetAll()
        {
            using (var db = new PizzaAppContext())
            {
                return db.PizzaSizes.Include(x => x.Pizza).Include(x => x.Size).ToList();
            }
        }

        public PizzaSize GetById(int id)
        {
            using (var db = new PizzaAppContext())
            {
                return db.PizzaSizes.Include(x => x.Pizza).Include(x => x.Size).FirstOrDefault(x => x.Id == id);
            }
        }

        public int Insert(PizzaSize entity)
        {
            using (var db = new PizzaAppContext())
            {
                db.Add(entity);
                db.SaveChanges();
                return entity.Id;
            }
        }

        public void Update(PizzaSize entity)
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
                var pizzaSize = db.PizzaSizes.FirstOrDefault(x => x.Id == id);

                if (pizzaSize == null)
                    throw new Exception("pizzaSize not found.");

                db.Remove(pizzaSize);
                db.SaveChanges();
            }
        }
    }
}
