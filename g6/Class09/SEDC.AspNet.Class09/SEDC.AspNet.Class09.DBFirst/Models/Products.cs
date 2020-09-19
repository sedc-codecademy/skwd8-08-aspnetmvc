using System;
using System.Collections.Generic;

namespace SEDC.AspNet.Class09.DBFirst.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SubCategoryId { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }

        public SubCategories SubCategory { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }
    }
}
