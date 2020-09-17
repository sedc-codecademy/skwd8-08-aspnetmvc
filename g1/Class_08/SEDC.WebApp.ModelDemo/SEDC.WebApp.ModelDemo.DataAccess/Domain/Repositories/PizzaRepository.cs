using SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.WebApp.ModelDemo.DataAccess.Domain.Repositories
{
    public class PizzaRepository : IRepository<Pizza>
    {
        private IStaticDb _db;
        public PizzaRepository(IStaticDb db)
        {
            _db = db;
        }
        public int Create(Pizza entity)
        {
            var pizzaModel = _db.GetPizzas().SingleOrDefault(pizza => pizza.Id == entity.Id);
            if (pizzaModel != null) return -1;
            _db.GetPizzas().ToList().Add(entity);
            return 1;
        }

        public int Delete(int id)
        {
            var pizzaModel = _db.GetPizzas().SingleOrDefault(pizza => pizza.Id == id);
            if (pizzaModel == null) return -1;
            _db.GetPizzas().ToList().Remove(pizzaModel);
            return 1;
        }

        public List<Pizza> GetAll()
        {
            return _db.GetPizzas().ToList();
        }

        public Pizza GetById(int id)
        {
            return _db.GetPizzas().SingleOrDefault(pizza => pizza.Id == id);
        }

        public int Update(Pizza entity)
        {
            var pizzaModel = _db.GetPizzas().SingleOrDefault(pizza => pizza.Id == entity.Id);
            if (pizzaModel == null) return -1;
            int pizzaIndex = _db.GetPizzas().ToList().IndexOf(pizzaModel);
            _db.GetPizzas().ToList()[pizzaIndex] = entity;
            return 1;
        }
    }
}
