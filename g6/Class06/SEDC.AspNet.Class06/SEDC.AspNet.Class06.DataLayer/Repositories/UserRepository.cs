using SEDC.AspNet.Class06.DataLayer.DomainModels;
using SEDC.AspNet.Class06.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AspNet.Class06.DataLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private Database _db;

        public UserRepository()
        {
            _db = new Database();
        }

        public List<User> GetAll()
        {
            return _db.Users;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public int Remove(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
