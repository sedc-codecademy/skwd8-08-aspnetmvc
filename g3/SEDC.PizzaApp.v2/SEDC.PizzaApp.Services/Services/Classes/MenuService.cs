using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.CashRepositories;
using SEDC.PizzaApp.DomainModels.Enums;
using SEDC.PizzaApp.DomainModels.Models;
using SEDC.PizzaApp.Services.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Services.Classes
{
    public class MenuService : IMenuService
    {
        private IRepository<Pizza> _pizzaRepository;

        public MenuService(IRepository<Pizza> pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public List<Pizza> GetMenu()
        {
            return _pizzaRepository.GetAll();
        }

        public Pizza GetPizzaByNameAndSize(string name, PizzaSize size) 
        {
            return _pizzaRepository.GetAll().FirstOrDefault(x => x.Name == name && x.Size == size);
        }

        public int AddPizzaInMenu(AddPizzaViewModel model) 
        {
            var LastPizzaId = GetMenu().Last().Id;

            var pizza = new Pizza()
            {
                Id = LastPizzaId + 1,
                Name = model.Name,
                Price = model.Price,
                Size = model.Size
            };

            var response = _pizzaRepository.Insert(pizza);
            return response;
        }
    }
}
