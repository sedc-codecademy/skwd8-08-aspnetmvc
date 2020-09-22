using SimpleAppWithEntity.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAppWithEntity.Services.Interfaces
{
    public interface IHomeService
    {
        void CreateNewName(NameViewModel model);
        NameViewModel GetAllNames();
    }
}
