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
        private IRepository<Pizza> _pizzaRepo;
        private IRepository<Order> _orderRepo;
        public PizzaService(IRepository<Pizza> pizzaRepository,IRepository<Order> orderRepo)
        {
            _pizzaRepo = pizzaRepository;
            _orderRepo = orderRepo;
        }
        public List<PizzaVM> GetPizzas()
        {
            var pizzas = _pizzaRepo.GetAll();
            var pizzasViewModelList = Mapper.MapListOfPizzasToListPizzaVM(pizzas);
            return pizzasViewModelList;
        }
        public PizzaVM GetPizzaById(int id)
        {
            var pizza = _pizzaRepo.GetById(id);
            var pizzaViewModel = Mapper.MapPizzaToPizzaVM(pizza);
            return pizzaViewModel;
        }

        public List<PizzaVM> GetPizzasByOrder(int orderId)
        {
            var order = _orderRepo.GetById(orderId);

            var pizzasVMS = Mapper.MapListOfPizzasToListPizzaVM(order.Pizzas);

            return pizzasVMS;
        }
        public bool AddPizza(PizzaVM pizza)
        {
            bool isPizzaAdded = _pizzaRepo.Save(Mapper.MapPizzaVMToPizza(pizza));
            if (isPizzaAdded)
            {
                return true;
            }
            return false;
        }

        public bool UpdatePizza(PizzaVM pizza)
        {
            bool isPizzaUpdated = _pizzaRepo.Edit(Mapper.MapPizzaVMToPizza(pizza));
            if (isPizzaUpdated)
            {
                return true;
            }
            return false;
        }

        public bool DeletePizza(PizzaVM pizza)
        {
            bool isPizzaDeleted = _pizzaRepo.Delete(Mapper.MapPizzaVMToPizza(pizza));
            if (isPizzaDeleted)
            {
                return true;
            }
            return false;
        }
    }
}
