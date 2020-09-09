using SEDC.AspNet.Class06.DataLayer.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AspNet.Class06.DataLayer
{
    public class Database
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>()
        {
            new Pizza
            {
                Id = 1,
                Name = "DemoPizza"
            }
        };
        public List<User> Users { get; set; } = new List<User>();
    }
}
