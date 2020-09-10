using SEDC.AspNet.Class06.DataLayer.DomainModels;
using SEDC.AspNet.Class06.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AspNet.Class06.DataLayer.Repositories
{
    public class EfPizzaRepository : IPizzaRepository
    {
        private List<Pizza> pizas = new List<Pizza>()
        {
            new Pizza
            {
                Id = 1001,
                Name = "EfPizza"
            }
        };

        public List<Pizza> GetAll()
        {
            return pizas;
        }

        public Pizza GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Pizza entity)
        {
            throw new NotImplementedException();
        }

        public int Remove(Pizza entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Pizza entity)
        {
            throw new NotImplementedException();
        }
    }
}
