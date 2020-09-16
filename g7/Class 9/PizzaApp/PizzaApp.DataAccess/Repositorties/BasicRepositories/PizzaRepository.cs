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
        private IDbContext _realDbContext;
        public PizzaRepository(IDb db,IDbContext realDbContext)
        {
            _db = db;
            _realDbContext = realDbContext;
        }
        public List<Pizza> GetAll()
        {
            return _realDbContext.Pizzas.ToList();
        }

        public Pizza GetById(int id)
        {
            Pizza pizza = _realDbContext.Pizzas.SingleOrDefault(p => p.ID == id);
            if (pizza == null)
            {
                throw new ApplicationException("The pizza does not exists!");
            }
            return pizza;
        }

        public bool Save(Pizza entity)
        {
            Pizza pizza = _realDbContext.Pizzas.SingleOrDefault(p => p.ID == entity.ID);
            if (pizza != null)
            {
                throw new ApplicationException("The pizza exists already!");
            }
            _realDbContext.Pizzas.Add(pizza);
            return true;
        }

        public bool Edit(Pizza entity)
        {
            Pizza pizza = _realDbContext.Pizzas.SingleOrDefault(p => p.ID == entity.ID);
            if (pizza == null)
            {
                throw new ApplicationException("The pizza does not exists you need to create it first!");
            }
            pizza.Name = entity.Name;
            pizza.Price = entity.Price;
            pizza.Size = entity.Size;
            _realDbContext.Pizzas.Update(pizza);
            return true;
        }

        public bool Delete(Pizza entity)
        {
            Pizza pizza = _realDbContext.Pizzas.SingleOrDefault(p => p.ID == entity.ID);
            if (pizza == null)
            {
                throw new ApplicationException("The pizza does not exist");
            }
            _realDbContext.Pizzas.Remove(pizza);

            return true;
        }
    }
}
