using SEDC.AspNet.PizzaApp.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.PizzaApp.App.Models.ViewModels
{
    public class PizzaVM
    {
        public int Id { get; set; } // 0
        [Required(ErrorMessage = "Name is required - custom")]
        public string Name { get; set; }
        public PizzaSize Size { get; set; }
        [Range(1,100, ErrorMessage = "Range must be betwen 1 and 100 - custom")]
        public double Price { get; set; }
    }
}
