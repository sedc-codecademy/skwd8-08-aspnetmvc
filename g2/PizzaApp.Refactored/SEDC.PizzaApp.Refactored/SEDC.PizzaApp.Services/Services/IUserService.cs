using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Services
{
    public interface IUserService
    {
        User GetUserById(int id);
        int AddNewUser(User entity);
        string GetLastUserName();
    }
}
