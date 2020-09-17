using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.BusinessModels.Models
{
    public class OrderVm
    {
        public int Id { get; set; }
        public UserVm User { get; set; }

        public List<PizzaOrderVm> PizzaOrders { get; set; } = new List<PizzaOrderVm>();

        public double Price
        {
            get
            {
                //if(PizzaOrders == null)
                //{
                //    return 0;
                //}

                return PizzaOrders.Sum(o => o.Pizza.Price) + 2;
            }
        }
    }
}
