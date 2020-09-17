using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class PizzaSizeViewModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Pizza")]
        public int PizzaId { get; set; }
        public PizzaViewModel PizzaViewModel { get; set; }
        [Required]
        [DisplayName("Size")]
        public int SizeId { get; set; }
        public SizeViewModel SizeViewModel { get; set; }
        [Required]
        [Range(1, 10000)]
        public int Price { get; set; }

        public PizzaSizeViewModel()
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
        }
    }
}
