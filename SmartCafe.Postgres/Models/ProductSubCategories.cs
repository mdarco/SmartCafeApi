using System;
using System.Collections.Generic;

namespace SmartCafe.Postgres.Models
{
    public partial class ProductSubCategories
    {
        public int ProductId { get; set; }
        public int SubCategoryId { get; set; }
        public string Note { get; set; }

        public virtual Products Product { get; set; }
        public virtual SubCategories SubCategory { get; set; }
    }
}
