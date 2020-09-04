using SEDC.WebApp.ModelDemo.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.WebApp.ModelDemo.Models.ViewModels
{
    public class PizzaVM
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Display(Name= "Pizza Name")]
        public string Name { get; set; }
        [Display(Name = "Pizza Size")]
        public PizzaSize Size { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
