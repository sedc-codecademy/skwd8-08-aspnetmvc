using SimpleAppWithEntity.DataAccess.Repositories;
using SimpleAppWithEntity.DataModels.Models;
using SimpleAppWithEntity.Services.Interfaces;
using SimpleAppWithEntity.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAppWithEntity.Services.Services
{
    public class HomeService : IHomeService
    {
        private IRepository<Name> _nameRepository;

        public HomeService(IRepository<Name> nameRepository)
        {
            _nameRepository = nameRepository;
        }
        public void CreateNewName(NameViewModel model)
        {
            var dbName = new Name()
            {
                MyName = model.MyName
            };

            _nameRepository.Insert(dbName);
        }

        public NameViewModel GetAllNames() 
        {
            var dbNames = _nameRepository.GetAll();

            var nameViewModel = new NameViewModel()
            {
                Names = new List<string>()
            };

            foreach (var name in dbNames)
            {
                nameViewModel.Names.Add(name.MyName);
            }

            return nameViewModel;
        }
    }
}
