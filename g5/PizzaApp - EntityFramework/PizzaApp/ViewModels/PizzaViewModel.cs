using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class PizzaViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DisplayName("Image")]
        public string ImageUrl { get; set; }

        public PizzaViewModel()
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
        }
    }
}
