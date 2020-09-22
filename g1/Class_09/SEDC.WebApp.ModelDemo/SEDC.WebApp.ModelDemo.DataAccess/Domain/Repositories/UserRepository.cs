using SEDC.WebApp.ModelDemo.DataAccess.DB;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.WebApp.ModelDemo.DataAccess.Domain.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private PizzaDbContext _db;
        public UserRepository(PizzaDbContext db)
        {
            _db = db;
        }
        public int Create(User entity)
        {
            var userModel = _db.Users.SingleOrDefault(user => user.Id == entity.Id);
            if (userModel != null) return -1;
            _db.Users.Add(entity);
            return _db.SaveChanges();
        }

        public int Delete(int id)
        {
            var userModel = _db.Users.SingleOrDefault(user => user.Id == id);
            if (userModel == null) return -1;
            _db.Users.Remove(userModel);
            return _db.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _db.Users.ToList();
        }

        public User GetById(int id)
        {
            return _db.Users.SingleOrDefault(user => user.Id == id);
        }

        public int Update(User entity)
        {
            var userModel = _db.Users.SingleOrDefault(user => user.Id == entity.Id);
            if (userModel == null) return -1;
            _db.Users.Update(entity);
            return _db.SaveChanges();
        }
    }
}
