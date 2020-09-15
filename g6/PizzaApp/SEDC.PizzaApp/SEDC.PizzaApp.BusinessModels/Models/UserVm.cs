using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.BusinessModels.Models
{
    public class UserVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }

        public List<OrderVm> Orders { get; set; }
    }
}
