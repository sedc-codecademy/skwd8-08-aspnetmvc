using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vnesi ime!")]
        public string Name { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Ja pretera!")]
        public int Quantity { get; set; }
        public ProductCategory Category { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [DisplayName("Produced by")]
        public string ProducedBy { get; set; }
        [Required]
        [DisplayName("Image")]
        public string ImageUrl { get; set; }

        public Product(string name, int quantity, ProductCategory category, decimal price, string producedBy,
            string imageUrl)
        {
            var rnd = new Random();
            Id = rnd.Next(1, 1000000000);
            Name = name;
            Quantity = quantity;
            Category = category;
            Price = price;
            ProducedBy = producedBy;
            ImageUrl = imageUrl;
        }

        public Product()
        {
            
        }
    }
}
