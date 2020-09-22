using SEDC.PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEDC.PizzaApp.Domain.Models
{
    public class Pizza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public List<PizzaOrder> PizzaOrders { get; set; }
    }
}
