using System;
using System.Collections.Generic;

namespace SmartCafe.Postgres.Models
{
    public partial class Categories
    {
        public Categories()
        {
            ProductCategories = new HashSet<ProductCategories>();
            SubCategories = new HashSet<SubCategories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductCategories> ProductCategories { get; set; }
        public virtual ICollection<SubCategories> SubCategories { get; set; }
    }
}
