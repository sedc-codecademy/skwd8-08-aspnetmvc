using System.Collections.Generic;
using ViewModels;

namespace Services.Interfaces
{
    public interface IPizzaSizeService
    {
        List<PizzaSizeViewModel> GetAll();
        PizzaSizeViewModel GetById(int id);
        void Save(PizzaSizeViewModel pizzaSizeViewModel);
        void Delete(int id);
    }
}
