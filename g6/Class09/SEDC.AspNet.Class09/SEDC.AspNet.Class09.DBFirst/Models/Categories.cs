using System;
using System.Collections.Generic;

namespace SEDC.AspNet.Class09.DBFirst.Models
{
    public partial class Categories
    {
        public Categories()
        {
            SubCategories = new HashSet<SubCategories>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }

        public ICollection<SubCategories> SubCategories { get; set; }
    }
}
