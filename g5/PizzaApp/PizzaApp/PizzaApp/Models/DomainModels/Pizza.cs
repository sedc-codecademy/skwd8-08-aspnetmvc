using System;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Models.DomainModels
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public Pizza()
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
        }

        public Pizza(string name, string description, string imageUrl)
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }

        public static PizzaViewModel ToViewModel(Pizza pizza)
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Description = pizza.Description,
                ImageUrl = pizza.ImageUrl
            };
        }
    }
}
