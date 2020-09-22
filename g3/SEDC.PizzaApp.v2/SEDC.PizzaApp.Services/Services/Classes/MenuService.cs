using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.DataAccess.Repositories.CashRepositories;
using SEDC.PizzaApp.DomainModels.Enums;
using SEDC.PizzaApp.DomainModels.Models;
using SEDC.PizzaApp.Services.Services.Interfaces;
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
    }
}
