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
    public class PizzaService : IPizzaService
    {
        private readonly IRepository<Pizza> _pizzaRepository;
        private readonly INotificationService _notificationService;

        public PizzaService(INotificationService notificationService)
        {
            _pizzaRepository = new PizzaRepository();
            _notificationService = notificationService;
        }

        public List<PizzaViewModel> GetAll()
        {
            return _pizzaRepository.GetAll().Select(x => x.ToViewModel()).ToList();
        }

        public PizzaViewModel GetById(int id)
        {
            var sendMail = _notificationService.Send("Body", "risto@gmail.com");
            var pizza = _pizzaRepository.GetById(id);

            if (pizza == null)
            {
                throw new Exception("Pizza not found");
            }

            return pizza.ToViewModel();
        }

        public void Delete(int id)
        {
            _pizzaRepository.Delete(id);
        }

        public void Save(PizzaViewModel model)
        {
            Pizza existingPizza = _pizzaRepository.GetById(model.Id);

            if (_pizzaRepository.GetAll().Any(x => x.Name == model.Name && x.Id != model.Id))
            {
                throw new Exception("Pizza with that name already exists");
            }

            if (existingPizza == null)
            {
                Pizza newPizza = new Pizza
                {
                    Id = model.Id,
                    Name = model.Name,
                    Description = model.Description,
                    ImageUrl = model.ImageUrl
                };

                _pizzaRepository.Insert(newPizza);
            }
            else
            {
                existingPizza.Name = model.Name;
                existingPizza.Description = model.Description;
                existingPizza.ImageUrl = model.ImageUrl;

                _pizzaRepository.Update(existingPizza);
            }
        }
    }
}
