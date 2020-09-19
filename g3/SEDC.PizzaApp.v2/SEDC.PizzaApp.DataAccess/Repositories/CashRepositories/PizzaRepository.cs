using SEDC.PizzaApp.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories.CashRepositories
{
    public class PizzaRepository : IRepository<Pizza>
    {
        public List<Pizza> GetAll()
        {
            return StaticDb.Menu;
        }

        public Pizza GetById(int id)
        {
            return StaticDb.Menu.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Pizza entity)
        {
            StaticDb.Menu.Add(entity);
            return entity.Id;
        }

        public void Update(Pizza entity)
        {
            var pizza = StaticDb.Menu.FirstOrDefault(x => x.Id == entity.Id);
            if (pizza != null)
            {
                var index = StaticDb.Menu.IndexOf(pizza);
                StaticDb.Menu[index] = entity;
            }
        }

        public void DeleteById(int id)
        {
            var pizza = StaticDb.Menu.FirstOrDefault(x => x.Id == id);
            if (pizza != null)
            {
                StaticDb.Menu.Remove(pizza);
            }
        }
    }
}
