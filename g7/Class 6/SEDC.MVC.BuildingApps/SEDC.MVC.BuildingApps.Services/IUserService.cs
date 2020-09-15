using SEDC.MVC.BuildingApps.Domain.Models;
using System.Collections.Generic;

namespace SEDC.MVC.BuildingApps.Services
{
    public interface IUserService
    {
        User GetUserById(int id);
        List<string> GetUserEmails();
    }
}
