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
    }
}
