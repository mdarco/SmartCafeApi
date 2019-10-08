using System;
using System.Collections.Generic;

namespace SmartCafe.Postgres.Models
{
    public partial class SubCategories
    {
        public SubCategories()
        {
            ProductSubCategories = new HashSet<ProductSubCategories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<ProductSubCategories> ProductSubCategories { get; set; }
    }
}
