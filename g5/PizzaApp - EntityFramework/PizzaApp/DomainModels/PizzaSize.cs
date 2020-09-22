using System;

namespace DomainModels
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

        public PizzaSize(Pizza pizza, Size size, int price)
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
            PizzaId = pizza.Id;
            Pizza = pizza;
            SizeId = size.Id;
            Size = size;
            Price = price;
        }
    }
}
