using System.Collections.Generic;
using ViewModels;

namespace Services.Interfaces
{
    public interface ISizeService
    {
        List<SizeViewModel> GetAll();
        SizeViewModel GetById(int id);
        void Save(SizeViewModel sizeViewModel);
        void Delete(int id);
    }
}
