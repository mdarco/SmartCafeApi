using System;
using System.Collections.Generic;

namespace SmartCafe.Postgres.Models
{
    public partial class ProductCategories
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Note { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Products Product { get; set; }
    }
}
