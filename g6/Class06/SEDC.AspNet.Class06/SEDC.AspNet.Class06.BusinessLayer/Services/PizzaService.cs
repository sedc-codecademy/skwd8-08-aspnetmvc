using SEDC.AspNet.Class06.BusinessLayer.Interfaces;
using SEDC.AspNet.Class06.BusinessLayer.ViewModels;
using SEDC.AspNet.Class06.DataLayer;
using SEDC.AspNet.Class06.DataLayer.DomainModels;
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
        private readonly IUserRepository _userRepository;

        public PizzaService(IPizzaRepository pizzaRepository)
        {
            // before 
            //_pizzaRepository = new PizzaRepository();
            // after new implemetation
            //_pizzaRepository = new EfPizzaRepository();
            _pizzaRepository = pizzaRepository;
            _userRepository = new UserRepository();
        }

        public List<PizzaVM> GetAllPizzas()
        {
            return _pizzaRepository.GetAll().Select(x => new PizzaVM { Id = x.Id, Name = x.Name }).ToList();
        }

        public UsersAndPizzasResult GetUsersAndPizzas()
        {
            // lots of logic here

            var pizzas = _pizzaRepository.GetAll();

            var result = new UsersAndPizzasResult
            {
                Pizzas = MapPizzas(pizzas),
                Users = _userRepository.GetAll(),
                Message = "Something good has happend"
            };

            BaseClassParameter(new User());
            BaseClassParameter(new Pizza());

            return result;
        }

        private IEnumerable<PizzaVM> MapPizzas(IEnumerable<Pizza> pizzas)
        {
            var listOfPizzasVM = new List<PizzaVM>();
            foreach (var pizza in pizzas)
            {
                var pzVM = MapPizza(pizza);
                listOfPizzasVM.Add(pzVM);
            }

            return listOfPizzasVM;

            //return pizzas.Select(x => new PizzaVM { Id = x.Id, Name = x.Name });
        }

        private PizzaVM MapPizza(Pizza pizza)
        {
            var pizzaVM = new PizzaVM
            {
                // map props
            };

            return pizzaVM;
        }

        private int BaseClassParameter(BaseEntity entity)
        {
            return entity.Id;
        }
    }
}
