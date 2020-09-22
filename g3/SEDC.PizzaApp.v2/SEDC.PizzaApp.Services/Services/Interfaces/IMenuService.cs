using SEDC.PizzaApp.DomainModels.Enums;
using SEDC.PizzaApp.DomainModels.Models;
using SEDC.PizzaApp.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Services.Interfaces
{
    public interface IMenuService
    {
        List<Pizza> GetMenu();

        Pizza GetPizzaByNameAndSize(string name, PizzaSize size);

        int AddPizzaInMenu(AddPizzaViewModel model);
    }
}
