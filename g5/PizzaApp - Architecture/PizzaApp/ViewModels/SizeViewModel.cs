using System;
using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class SizeViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public SizeViewModel()
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
        }
    }
}
