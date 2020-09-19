using System.Collections.Generic;
using DomainModels;

namespace DataAccess
{
    public static class StaticDatabase
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
            new PizzaSize(Pizzas[0], Sizes[0], 150),
            new PizzaSize(Pizzas[0], Sizes[1], 250),
            new PizzaSize(Pizzas[0], Sizes[2], 350),
            new PizzaSize(Pizzas[1], Sizes[0], 180),
            new PizzaSize(Pizzas[1], Sizes[1], 280),
            new PizzaSize(Pizzas[1], Sizes[2], 380),
        };

        //public static IEnumerable<SelectListItem> PizzasToSelectListItems()
        //{
        //    return Pizzas.Select(x => new SelectListItem(x.Name, x.Id.ToString()));
        //}
        
        //public static IEnumerable<SelectListItem> SizesToSelectListItems()
        //{
        //    return Sizes.Select(x => new SelectListItem(x.Name, x.Id.ToString()));
        //}

        //public static IEnumerable<SelectListItem> PizzaSizesToSelectListItems()
        //{
        //    return PizzaSizes.Select(x =>
        //        new SelectListItem(
        //            $"{x.Pizza.Name} - {x.Size.Name} ({x.Price.ToString("C", new CultureInfo("mk-MK"))})",
        //            x.Id.ToString())).ToList();
        //}
    }
}
