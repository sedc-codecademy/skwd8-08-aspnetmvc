using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.PresentationLayer.ViewModels;
using System.Collections.Generic;

namespace PizzaApp.Services.Services.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaVM> GetPizzas();
        PizzaVM GetPizzaById(int id);
        List<PizzaVM> GetPizzasByOrder(int orderId);
        bool AddPizza(PizzaVM pizza);
        bool UpdatePizza(PizzaVM pizza);
        bool DeletePizza(PizzaVM pizza);
    }
}
