using SEDC.AspNet.Class06.BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AspNet.Class06.BusinessLayer.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaVM> GetAllPizzas();
        UsersAndPizzasResult GetUsersAndPizzas();
    }
}
