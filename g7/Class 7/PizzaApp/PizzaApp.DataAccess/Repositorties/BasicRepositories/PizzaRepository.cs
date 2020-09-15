using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.DataAccess.Db.DbAccess;
using PizzaApp.DataAccess.Db.Interfaces;
using PizzaApp.DataAccess.Repositorties.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.DataAccess.Repositorties.BasicRepositories
{
    public class PizzaRepository : IRepository<Pizza>
    {
        private IDb _db;
        public PizzaRepository(IDb db)
        {
            _db = db;
        }
        public List<Pizza> GetAll()
        {
            return _db.SeedPizzas();
        }

        public Pizza GetById(int id)
        {
            Pizza pizza = _db.SeedPizzas().SingleOrDefault(p => p.ID == id);
            if (pizza == null)
            {
                throw new ApplicationException("The pizza does not exists!");
            }
            return pizza;
        }

        public bool Save(Pizza entity)
        {
            Pizza pizza = _db.SeedPizzas().SingleOrDefault(p => p.ID == entity.ID);
            if (pizza != null)
            {
                throw new ApplicationException("The pizza exists already!");
            }
            _db.SeedPizzas().Add(pizza);
            return true;
        }

        public bool Edit(Pizza entity)
        {
            Pizza pizza = _db.SeedPizzas().SingleOrDefault(p => p.ID == entity.ID);
            if (pizza == null)
            {
                throw new ApplicationException("The pizza does not exists you need to create it first!");
            }
            pizza.Name = entity.Name;
            pizza.Price = entity.Price;
            pizza.Size = entity.Size;
            _db.SeedPizzas().Add(pizza);
            return true;
        }

        public bool Delete(Pizza entity)
        {
            Pizza pizza = _db.SeedPizzas().SingleOrDefault(p => p.ID == entity.ID);
            if (pizza == null)
            {
                throw new ApplicationException("The pizza does not exist");
            }
            _db.SeedPizzas().Remove(pizza);
            return true;
        }
    }
}
