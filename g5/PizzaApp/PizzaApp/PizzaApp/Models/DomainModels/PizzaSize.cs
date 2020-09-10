using System;
using System.Linq;
using PizzaApp.Helper;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Models.DomainModels
{
    public class PizzaSize
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
        public int Price { get; set; }

        public PizzaSize()
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
        }

        public PizzaSize(int pizzaId, int sizeId, int price)
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
            PizzaId = pizzaId;
            Pizza = Data.Pizzas.FirstOrDefault(x => x.Id == pizzaId);
            SizeId = sizeId;
            Size = Data.Sizes.FirstOrDefault(x => x.Id == sizeId);
            Price = price;
        }

        public static PizzaSizeViewModel ToViewModel(PizzaSize pizzaSize)
        {
            return new PizzaSizeViewModel
            {
                Id = pizzaSize.Id,
                PizzaId = pizzaSize.PizzaId,
                PizzaViewModel = Pizza.ToViewModel(pizzaSize.Pizza),
                SizeId = pizzaSize.SizeId,
                SizeViewModel = Size.ToViewModel(pizzaSize.Size),
                Price = pizzaSize.Price
            };
        }
    }
}
