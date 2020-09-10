using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaApp.Models.DomainModels;

namespace PizzaApp.Helper
{
    public static class Data
    {
        public static List<Customer> Customers { get; set; } = new List<Customer>()
        {
            new Customer("Risto", "Panchevski", "Gjorce Petrov", "070123456"),
            new Customer("Petko", "Petkovski", "Centar", "070654321")
        };
        public static List<Pizza> Pizzas { get; set; } = new List<Pizza>()
        {
            new Pizza("Capricioza", "Tomato, ham, mushroom, cheese", "https://pizzapempele.mk/wp-content/uploads/2014/11/pizza_capriciossa-520x390.jpg"),
            new Pizza("Peperoni", "Tomato, peperoni, mushroom, cheese", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Fck%2Fgluten-free-cookbook%2Fpepperoni-pizza-ck-x.jpg"),
            new Pizza("Makedonska", "Tomato, ham, mushroom, cheese, olives, pepper", "https://stonepizzas.com/wp-content/uploads/2016/10/veg_small.png"),
        };
        public static List<Size> Sizes { get; set; } = new List<Size>()
        {
            new Size("Mala", "30cm"),
            new Size("Sredna", "45cm"),
            new Size("Golema", "60cm")
        };
        public static List<PizzaSize> PizzaSizes { get; set; } = new List<PizzaSize>()
        {
            new PizzaSize(Pizzas[0].Id, Sizes[0].Id, 150),
            new PizzaSize(Pizzas[0].Id, Sizes[1].Id, 250),
            new PizzaSize(Pizzas[0].Id, Sizes[2].Id, 350),
            new PizzaSize(Pizzas[1].Id, Sizes[0].Id, 180),
            new PizzaSize(Pizzas[1].Id, Sizes[1].Id, 280),
            new PizzaSize(Pizzas[1].Id, Sizes[2].Id, 380),
        };

        public static IEnumerable<SelectListItem> PizzasToSelectListItems()
        {
            return Pizzas.Select(x => new SelectListItem(x.Name, x.Id.ToString()));
        }
        
        public static IEnumerable<SelectListItem> SizesToSelectListItems()
        {
            return Sizes.Select(x => new SelectListItem(x.Name, x.Id.ToString()));
        }
    }
}
