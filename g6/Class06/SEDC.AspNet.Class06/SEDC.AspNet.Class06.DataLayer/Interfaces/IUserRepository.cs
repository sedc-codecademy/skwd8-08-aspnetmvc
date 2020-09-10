using SEDC.AspNet.Class06.DataLayer.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AspNet.Class06.DataLayer.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User GetById(int id);
        void Insert(User entity);
        void Update(User entity);
        int Remove(User entity);
    }
}
