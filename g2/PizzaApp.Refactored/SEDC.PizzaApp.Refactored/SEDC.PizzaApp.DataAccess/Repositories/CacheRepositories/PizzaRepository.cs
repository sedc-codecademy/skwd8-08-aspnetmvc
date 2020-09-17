using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories.CacheRepositories
{
    public class PizzaRepository : IRepository<Pizza>
    {
        public List<Pizza> GetAll()
        {
            return CacheDb.Menu;
        }

        public Pizza GetById(int id)
        {
            return CacheDb.Menu.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Pizza entity)
        {
            CacheDb.PizzaId++;
            entity.Id = CacheDb.PizzaId;
            CacheDb.Menu.Add(entity);
            return entity.Id;
        }

        public void Update(Pizza entity)
        {
            Pizza pizza = CacheDb.Menu.SingleOrDefault(x => x.Id == entity.Id);
            if(pizza != null)
            {
                int index = CacheDb.Menu.IndexOf(pizza);
                CacheDb.Menu[index] = entity;
            }
        }

        public void DeleteById(int id)
        {
            Pizza pizza = CacheDb.Menu.SingleOrDefault(x => x.Id == id);
            if (pizza != null)
                CacheDb.Menu.Remove(pizza);
        }

    }
}
