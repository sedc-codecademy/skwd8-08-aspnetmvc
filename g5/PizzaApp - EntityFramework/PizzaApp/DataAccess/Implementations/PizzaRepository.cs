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
            return StaticDatabase.Pizzas;
        }

        public Pizza GetById(int id)
        {
            return StaticDatabase.Pizzas.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Pizza entity)
        {
            StaticDatabase.Pizzas.Add(entity);
            return entity.Id;
        }

        public void Update(Pizza entity)
        {
            var pizza = StaticDatabase.Pizzas.FirstOrDefault(x => x.Id == entity.Id);

            if (pizza == null)
            {
                throw new Exception("Pizza not found");
            }

            int index = StaticDatabase.Pizzas.IndexOf(pizza);
            StaticDatabase.Pizzas[index] = entity;
        }

        public void Delete(int id)
        {
            var pizza = StaticDatabase.Pizzas.FirstOrDefault(x => x.Id == id);

            if (pizza == null)
            {
                throw new Exception("Pizza not found");
            }

            var index = StaticDatabase.Pizzas.IndexOf(pizza);
            StaticDatabase.Pizzas.RemoveAt(index);
        }
    }
}
