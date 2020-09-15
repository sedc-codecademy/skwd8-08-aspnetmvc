using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Services.Services.Interfaces
{
    public interface IUserService
    {
        List<UserVM> GetAllUsers();
        UserVM GetUserById(int id);
        List<UserVM> GetUsersWithDiscount(List<UserVM> orders);
        User AddUser(UserVM user);
        User UpdateUser(UserVM user);
        bool DeleteUser(UserVM user);
    }
}
