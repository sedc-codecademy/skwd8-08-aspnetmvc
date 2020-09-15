using SEDC.MVC.BuildingApps.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.MVC.BuildeingApps.DataAccess
{
    public class UserRepository : IRepository<User>
    {

        public void Insert(User entity)
        {
            Databse.Users.Add(entity);
        }

        public List<User> GetAll()
        {
            return Databse.Users;
        }

        public void Update(User entity)
        {
            User oldEntity = Databse.Users.FirstOrDefault(u => u.Id == entity.Id);

            if (oldEntity != null)
            {
                oldEntity.Email = entity.Email;
            }         
        }

        public void DeleteById(int id)
        {
            User userToDelete = Databse.Users.FirstOrDefault(u => u.Id == id);

            if (userToDelete != null)
            {
                Databse.Users.Remove(userToDelete);
            }
        }
    }
}
