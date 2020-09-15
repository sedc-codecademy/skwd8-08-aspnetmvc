using SEDC.PizzaApp.BusinessModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.BusinessLayer.Interfaces
{
    public interface IUserService
    {
        UserVm GetUserById(int id);
        string GetLastUsername();
        //int AddNewUser(CreateUserVm model)
    }
}
