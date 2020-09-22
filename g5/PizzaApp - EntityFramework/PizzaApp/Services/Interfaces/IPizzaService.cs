using System.Collections.Generic;
using DomainModels;
using ViewModels;

namespace Services.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaViewModel> GetAll();
        PizzaViewModel GetById(int id);
        void Delete(int id);
        void Save(PizzaViewModel model);
    }
}
