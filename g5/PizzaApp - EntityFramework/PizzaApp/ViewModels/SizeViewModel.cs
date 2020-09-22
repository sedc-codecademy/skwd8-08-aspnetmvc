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
        }
    }
}
