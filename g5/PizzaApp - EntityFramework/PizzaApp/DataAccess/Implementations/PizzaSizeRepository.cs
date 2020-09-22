using System;
using System.Collections.Generic;
using System.Linq;
using DomainModels;

namespace DataAccess.Implementations
{
    public class PizzaSizeRepository : IRepository<PizzaSize>
    {
        public List<PizzaSize> GetAll()
        {
            return StaticDatabase.PizzaSizes;
        }

        public PizzaSize GetById(int id)
        {
            return StaticDatabase.PizzaSizes.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(PizzaSize entity)
        {
            StaticDatabase.PizzaSizes.Add(entity);
            return entity.Id;
        }

        public void Update(PizzaSize entity)
        {
            PizzaSize pizzaSize = StaticDatabase.PizzaSizes.FirstOrDefault(x => x.Id == entity.Id);
            if (pizzaSize == null)
            {
                throw new Exception($"PizzaSize with id {entity.Id} was not found");
            }
            //update the record in DB
            int index = StaticDatabase.PizzaSizes.IndexOf(pizzaSize);
            StaticDatabase.PizzaSizes[index] = entity;
        }

        public void Delete(int id)
        {
            PizzaSize pizzaSize = StaticDatabase.PizzaSizes.FirstOrDefault(x => x.Id == id);
            if (pizzaSize == null)
            {
                throw new Exception($"PizzaSize with id {id} was not found");
            }
            //delete record from DB
            int index = StaticDatabase.PizzaSizes.IndexOf(pizzaSize);
            StaticDatabase.PizzaSizes.RemoveAt(index);
        }
    }
}
