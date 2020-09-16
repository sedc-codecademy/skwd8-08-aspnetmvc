using SEDC.PizzaApp.v1.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.v1.Models.ViewModels
{
    public class MenuViewModel
    {
        public List<PizzaViewModel> Menu { get; set; }
        public List<string> PizzaNames { get; set; }
    }
}
