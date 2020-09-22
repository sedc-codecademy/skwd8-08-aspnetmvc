using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using DataAccess.Implementations;
using DomainModels;
using Mappers;
using Services.Interfaces;
using ViewModels;

namespace Services.Implementations
{
    public class PizzaSizeService : IPizzaSizeService
    {
        private readonly IRepository<PizzaSize> _pizzaSizeRepository;
        private readonly IRepository<Pizza> _pizzaRepository;
        private readonly IRepository<Size> _sizeRepository;

        public PizzaSizeService(IRepository<Size> sizeRepository, IRepository<Pizza> pizzaRepository, IRepository<PizzaSize> pizzaSizeRepository)
        {
            _sizeRepository = sizeRepository;
            _pizzaRepository = pizzaRepository;
            _pizzaSizeRepository = pizzaSizeRepository;
        }

        public List<PizzaSizeViewModel> GetAll()
        {
            return _pizzaSizeRepository.GetAll().Select(x => x.ToViewModel()).ToList();
        }

        public PizzaSizeViewModel GetById(int id)
        {
            PizzaSize pizzaSize = _pizzaSizeRepository.GetById(id);

            if (pizzaSize == null)
            {
                throw new Exception($"PizzaSize with id {id} not found");
            }

            return pizzaSize.ToViewModel();
        }

        public void Save(PizzaSizeViewModel pizzaSizeViewModel)
        {
            PizzaSize existingPizzaSize = _pizzaSizeRepository.GetById(pizzaSizeViewModel.Id);

            Pizza pizza = _pizzaRepository.GetById(pizzaSizeViewModel.PizzaId);
            Size size = _sizeRepository.GetById(pizzaSizeViewModel.SizeId);

            if (existingPizzaSize == null)
            {
                PizzaSize newPizzaSize = new PizzaSize(pizza, size, pizzaSizeViewModel.Price);

                _pizzaSizeRepository.Insert(newPizzaSize);
            }
            else
            {
                existingPizzaSize.PizzaId = pizza.Id;
                existingPizzaSize.Pizza = pizza;
                existingPizzaSize.SizeId = size.Id;
                existingPizzaSize.Size = size;
                existingPizzaSize.Price = pizzaSizeViewModel.Price;

                _pizzaSizeRepository.Update(existingPizzaSize);
            }
        }

        public void Delete(int id)
        {
            _pizzaSizeRepository.Delete(id);
        }
    }
}
