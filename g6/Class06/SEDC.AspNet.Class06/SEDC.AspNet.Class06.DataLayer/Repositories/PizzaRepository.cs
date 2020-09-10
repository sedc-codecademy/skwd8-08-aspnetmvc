using SEDC.AspNet.Class06.DataLayer.DomainModels;
using SEDC.AspNet.Class06.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AspNet.Class06.DataLayer.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {
        private Database _db;

        public PizzaRepository()
        {
            _db = new Database();
        }

        public List<Pizza> GetAll()
        {
            return _db.Pizzas;
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
