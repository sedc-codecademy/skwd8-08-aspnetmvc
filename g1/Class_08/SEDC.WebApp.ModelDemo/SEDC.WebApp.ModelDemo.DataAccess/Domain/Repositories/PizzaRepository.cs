using SEDC.WebApp.ModelDemo.DataAccess.DB;
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
        private PizzaDbContext _db;
        public PizzaRepository(PizzaDbContext db)
        {
            _db = db;
        }

        public int Create(Pizza entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetAll()
        {
            return _db.Pizzas.ToList();
        }

        public Pizza GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Pizza entity)
        {
            throw new NotImplementedException();
        }
    }
}
