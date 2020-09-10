using SEDC.AspNet.Class06.BusinessLayer.Interfaces;
using SEDC.AspNet.Class06.BusinessLayer.ViewModels;
using SEDC.AspNet.Class06.DataLayer.Interfaces;
using SEDC.AspNet.Class06.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.AspNet.Class06.BusinessLayer.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _pizzaRepository;
        //private readonly IUserRepository _userRepository;

        public PizzaService()
        {
            // before 
            //_pizzaRepository = new PizzaRepository();
            // after new implemetation
            _pizzaRepository = new EfPizzaRepository();
            //_userRepository = new UserRepository();
        }

        public List<PizzaVM> GetAllPizzas()
        {
            return _pizzaRepository.GetAll().Select(x => new PizzaVM { Id = x.Id, Name = x.Name }).ToList();
        }
    }
}
