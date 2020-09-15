using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.WebApp.ModelDemo.DataAccess.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public bool Delivered { get; set; }
        public User User { get; set; }
        public Pizza Pizza { get; set; }
    }
}
