using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.DataAccess.Repositorties.Interfaces;
using PizzaApp.PresentationLayer.ViewModels;
using PizzaApp.Services.Mappings;
using PizzaApp.Services.Services.Interfaces;
using System.Collections.Generic;

namespace PizzaApp.Services.Services.BasicServices
{
    public class PizzaService : IPizzaService
    {
        private readonly IRepository<Pizza> _pizzaRepo;
        private readonly IRepository<Order> _orderRepo;

        public PizzaService(IRepository<Pizza> pizzaRepository,IRepository<Order> orderRepo)
        {
            _pizzaRepo = pizzaRepository;
            _orderRepo = orderRepo;
        }

        public List<PizzaVM> GetPizzas()
        {
            var pizzas = _pizzaRepo.GetAll();
            var pizzasViewModelList = PizzaMapper.MapListOfPizzasToListPizzaVM(pizzas);
            return pizzasViewModelList;
        }

        public PizzaVM GetPizzaById(int id)
        {
            var pizza = _pizzaRepo.GetById(id);
            var pizzaViewModel = PizzaMapper.MapPizzaToPizzaVM(pizza);
            return pizzaViewModel;
        }

        public List<PizzaVM> GetPizzasByOrder(int orderId)
        {
            var order = _orderRepo.GetById(orderId);

            var pizzasVMS = PizzaMapper.MapListOfPizzasToListPizzaVM(order.Pizzas);

            return pizzasVMS;
        }
        public bool AddPizza(PizzaVM pizza)
        {
            return _pizzaRepo.Save(PizzaMapper.MapPizzaVMToPizza(pizza));
        }

        public bool UpdatePizza(PizzaVM pizza)
        {
            return _pizzaRepo.Edit(PizzaMapper.MapPizzaVMToPizza(pizza));
        }

        public bool DeletePizza(PizzaVM pizza)
        {
            return _pizzaRepo.Delete(PizzaMapper.MapPizzaVMToPizza(pizza));
        }
    }
}
