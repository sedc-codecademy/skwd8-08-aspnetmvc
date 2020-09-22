using DomainModels;
using ViewModels;

namespace Mappers
{
    public static class PizzaSizeMapper
    {
        public static PizzaSizeViewModel ToViewModel(this PizzaSize pizzaSize)
        {
            return new PizzaSizeViewModel
            {
                Id = pizzaSize.Id,
                PizzaId = pizzaSize.PizzaId,
                PizzaViewModel = pizzaSize.Pizza.ToViewModel(),
                SizeId = pizzaSize.SizeId,
                SizeViewModel = pizzaSize.Size.ToViewModel(),
                Price = pizzaSize.Price
            };
        }
    }
}
