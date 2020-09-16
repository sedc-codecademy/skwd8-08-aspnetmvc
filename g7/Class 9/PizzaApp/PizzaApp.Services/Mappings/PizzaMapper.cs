using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.PresentationLayer.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.Services.Mappings
{
    public static class PizzaMapper
    {
        public static List<PizzaVM> MapListOfPizzasToListPizzaVM(List<Pizza> pizzas)
        {
            var vms = pizzas.Select(p => new PizzaVM() { Name = p.Name, Price = p.Price, Size = p.Size }).ToList();
            return vms;
        }

        public static List<Pizza> MapPizzasVMsToPizzas(List<PizzaVM> pizzasVMS)
        {
            var pizzas = pizzasVMS.Select(pvm => new Pizza() { Name = pvm.Name, Price = pvm.Price, Size = pvm.Size }).ToList();
            return pizzas;
        }

        public static PizzaVM MapPizzaToPizzaVM(Pizza pizza)
        {
            return new PizzaVM()
            {
                Name = pizza.Name,
                Price = pizza.Price,
                Size = pizza.Size
            };
        }

        public static Pizza MapPizzaVMToPizza(PizzaVM pizzaVM)
        {
            return new Pizza()
            {
                Name = pizzaVM.Name,
                Price = pizzaVM.Price,
                Size = pizzaVM.Size
            };
        }
    }
}
