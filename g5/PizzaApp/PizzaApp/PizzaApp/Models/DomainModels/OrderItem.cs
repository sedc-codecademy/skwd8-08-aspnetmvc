namespace PizzaApp.Models.DomainModels
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int PizzaSizeId { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
