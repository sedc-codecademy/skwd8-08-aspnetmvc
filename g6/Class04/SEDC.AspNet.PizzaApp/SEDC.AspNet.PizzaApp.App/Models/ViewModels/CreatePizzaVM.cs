using SEDC.AspNet.PizzaApp.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.PizzaApp.App.Models.ViewModels
{
    public class CreatePizzaVM
    {
        [Required(ErrorMessage = "Name is required - custom")]
        public string Name { get; set; }
        public PizzaSize Size { get; set; }
        [Required]
        //[Range(1, 100, ErrorMessage = "Range must be betwen 1 and 100 - custom")]
        public double? Price { get; set; }
    }
}
