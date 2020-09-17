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
        private IStaticDb _db;
        public UserRepository(IStaticDb db)
        {
            _db = db;
        }
        public int Create(User entity)
        {
            var userModel = _db.GetUsers().SingleOrDefault(user => user.Id == entity.Id);
            if (userModel != null) return -1;
            _db.GetUsers().ToList().Add(entity);
            return 1;
        }

        public int Delete(int id)
        {
            var userModel = _db.GetUsers().SingleOrDefault(user => user.Id == id);
            if (userModel == null) return -1;
            _db.GetUsers().ToList().Remove(userModel);
            return 1;
        }

        public List<User> GetAll()
        {
            return _db.GetUsers().ToList();
        }

        public User GetById(int id)
        {
            return _db.GetUsers().SingleOrDefault(user => user.Id == id);
        }

        public int Update(User entity)
        {
            var userModel = _db.GetUsers().SingleOrDefault(user => user.Id == entity.Id);
            if (userModel == null) return -1;
            int userIndex = _db.GetUsers().ToList().IndexOf(userModel);
            _db.GetUsers().ToList()[userIndex] = entity;
            return 1;
        }
    }
}
