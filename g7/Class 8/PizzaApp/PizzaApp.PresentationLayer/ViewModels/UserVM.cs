using PizzaApp.DataAccess.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.PresentationLayer.ViewModels
{
    public class UserVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public List<OrderVM> Orders { get; set; }
    }
}
