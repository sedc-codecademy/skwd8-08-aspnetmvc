namespace PizzaApp.Web.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public Pizza Pizza { get; set; }
        public double Price { get; set; }
        public User User { get; set; }
        public bool Delivered { get; set; }
    }
}
