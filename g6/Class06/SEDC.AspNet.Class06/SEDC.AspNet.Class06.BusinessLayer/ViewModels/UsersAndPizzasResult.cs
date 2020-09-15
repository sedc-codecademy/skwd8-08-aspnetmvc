using SEDC.AspNet.Class06.DataLayer.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AspNet.Class06.BusinessLayer.ViewModels
{
    public class UsersAndPizzasResult
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<PizzaVM> Pizzas { get; set; }
        public string Message { get; set; }
        public string Error { get; set; }
    }
}
