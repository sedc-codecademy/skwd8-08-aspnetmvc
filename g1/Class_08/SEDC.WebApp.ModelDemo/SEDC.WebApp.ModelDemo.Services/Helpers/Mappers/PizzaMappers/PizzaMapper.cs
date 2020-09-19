using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.WebApp.ModelDemo.Services.Helpers.Mappers.PizzaMappers
{
    public static class PizzaMapper
    {
        public static Pizza PizzaVMtoPizza(PizzaVM model)
        {
            return new Pizza()
            {
                Size= model.Size,
                Image = model.Image,
                Name = model.Name,
                Price = model.Price,
                Id = model.Id
            };
        }

        public static PizzaVM PizzaToPizzaVM(Pizza model)
        {
            return new PizzaVM()
            {
                Size = model.Size,
                Image = model.Image,
                Name = model.Name,
                Price = model.Price,
                Id = model.Id
            };
        }

        public static List<Pizza> PizzasVMtoPizzas(List<PizzaVM> models)
        {

            return models.Select(pizzaVM => new Pizza()
            {
                Size = pizzaVM.Size,
                Image = pizzaVM.Image,
                Name = pizzaVM.Name,
                Price = pizzaVM.Price,
                Id = pizzaVM.Id
            }).ToList();

            // return models.Select(pizzaVM=> PizzaVMtoPizza(pizzaVM))

        }

        public static List<PizzaVM> PizzasToPizzasVM(List<Pizza> models)
        {

            return models.Select(pizza => new PizzaVM()
            {
                Size = pizza.Size,
                Image = pizza.Image,
                Name = pizza.Name,
                Price = pizza.Price,
                Id = pizza.Id
            }).ToList();

            // return models.Select(order=> PizzaToPizzaVM(order))

        }
    }
}
