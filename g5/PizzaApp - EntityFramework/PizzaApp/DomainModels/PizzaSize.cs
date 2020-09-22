using System;

namespace DomainModels
{
    public class PizzaSize
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public virtual Pizza Pizza { get; set; }
        public int SizeId { get; set; }
        public virtual Size Size { get; set; }
        public int Price { get; set; }

        public PizzaSize()
        {
        }

        public PizzaSize(Pizza pizza, Size size, int price)
        {
            PizzaId = pizza.Id;
            SizeId = size.Id;
            Price = price;
        }
    }
}
