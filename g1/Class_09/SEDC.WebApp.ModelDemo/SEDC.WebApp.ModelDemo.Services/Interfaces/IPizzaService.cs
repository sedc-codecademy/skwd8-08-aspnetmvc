using SEDC.WebApp.ModelDemo.DataAccess.Domain.Enums;
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaVM> GetAllPizzas();
        PizzaVM GetPizzaById(int id);
        List<PizzaVM> GetPizzasBySize(PizzaSize size);
    }
}
