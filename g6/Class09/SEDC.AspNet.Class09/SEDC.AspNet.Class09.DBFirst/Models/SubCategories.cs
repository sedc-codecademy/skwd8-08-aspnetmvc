using System;
using System.Collections.Generic;

namespace SEDC.AspNet.Class09.DBFirst.Models
{
    public partial class SubCategories
    {
        public SubCategories()
        {
            Products = new HashSet<Products>();
        }

        public int SubCategoryId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public Categories Category { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
