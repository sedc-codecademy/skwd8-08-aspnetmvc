using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }
        [Required]
        public int PizzaSizeId { get; set; }
        public PizzaSizeViewModel PizzaSize { get; set; }
        [Required]
        [Range(1, 10)]
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int Total => Quantity * PizzaSize?.Price ?? 0;
    }
}
