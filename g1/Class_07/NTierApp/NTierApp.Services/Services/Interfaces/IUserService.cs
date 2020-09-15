using NTierApp.DataAccess.Core.Entities;
using NTIerApp.PresentationLayer.ViewModels;
using System.Collections.Generic;

namespace NTierApp.Services.Services.Interfaces
{
    public interface IUserService
    {
        List<UserVM> GetAllUsers();
        UserVM GetUserWithMostOrders(List<User> users);
        UserVM GetUserById(int id);
        bool CreateUser(UserVM user);
        bool UpdateUser(UserVM user);
        bool DeleteUser(UserVM user);
    }
}
