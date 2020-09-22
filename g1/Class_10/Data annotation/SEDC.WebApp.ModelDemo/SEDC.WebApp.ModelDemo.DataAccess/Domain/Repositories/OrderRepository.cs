using SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SEDC.WebApp.ModelDemo.DataAccess.DB;

namespace SEDC.WebApp.ModelDemo.DataAccess.Domain.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private PizzaDbContext _dbContext;
        public OrderRepository(PizzaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Order> GetAll()
        {
            return _dbContext.Orders.Include(x => x.Pizza).Include(x => x.User).ToList();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Create(Order entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Order entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
