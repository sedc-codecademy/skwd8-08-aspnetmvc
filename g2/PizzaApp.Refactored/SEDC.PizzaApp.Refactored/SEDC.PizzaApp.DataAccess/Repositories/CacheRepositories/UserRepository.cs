using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories.CacheRepositories
{
    public class UserRepository : IRepository<User>
    {
        public List<User> GetAll()
        {
            return CacheDb.Users;
        }

        public User GetById(int id)
        {
            return CacheDb.Users.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(User entity)
        {
            CacheDb.UserId++;
            entity.Id = CacheDb.UserId;
            CacheDb.Users.Add(entity);
            return entity.Id;
        }

        public void Update(User entity)
        {
            User user = CacheDb.Users.SingleOrDefault(x => x.Id == entity.Id);
            if(user != null)
            {
                int index = CacheDb.Users.IndexOf(user);
                CacheDb.Users[index] = entity;
            }
        }

        public void DeleteById(int id)
        {
            User user = CacheDb.Users.SingleOrDefault(x => x.Id == id);
            if (user != null)
                CacheDb.Users.Remove(user);
        }
    }
}
