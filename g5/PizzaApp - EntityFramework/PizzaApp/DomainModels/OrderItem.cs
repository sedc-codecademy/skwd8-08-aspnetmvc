namespace DomainModels
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int PizzaSizeId { get; set; }
        public virtual PizzaSize PizzaSize { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int orderId)
        {
            OrderId = orderId;
        }

        public OrderItem(PizzaSize pizzaSize, int quantity, int orderId)
        {
            PizzaSizeId = pizzaSize.Id;
            Quantity = quantity;
            OrderId = orderId;
        }
    }
}
