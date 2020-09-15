using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.DataAccess.Db.Interfaces;
using PizzaApp.DataAccess.Repositorties.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.DataAccess.Repositorties.BasicRepositories
{
    public class UserRepository : IRepository<User>
    {
        private IDb _db;
        public UserRepository(IDb db)
        {
            _db = db;
        }
        public List<User> GetAll()
        {
            return _db.SeedUsers();
        }

        public User GetById(int id)
        {
            User user = _db.SeedUsers().SingleOrDefault(x => x.ID == id);
            if (user == null)
            {
                throw new ApplicationException("The user does not exists");
            }
            return user;
        }

        public bool Save(User entity)
        {
            User user = _db.SeedUsers().SingleOrDefault(x => x.ID == entity.ID);
            if (user != null)
            {
                throw new ApplicationException("The user  exists");
            }
            _db.SeedUsers().Add(user);
            return true;
        }

        public bool Edit(User entity)
        {
            User user = _db.SeedUsers().SingleOrDefault(x => x.ID == entity.ID);
            if (user == null)
            {
                throw new ApplicationException("The user does not exists");
            }
            user.FirstName = entity.FirstName;
            user.LastName = entity.LastName;
            user.UserName = entity.UserName;
            user.Password = entity.Password;
            _db.SeedUsers().Add(user);
            return true;
        }

        public bool Delete(User entity)
        {
            User user = _db.SeedUsers().SingleOrDefault(x => x.ID == entity.ID);
            if (user == null)
            {
                throw new ApplicationException("The user does not exists");
            }
            _db.SeedUsers().Remove(user);
            return true;
        }
    }
}
