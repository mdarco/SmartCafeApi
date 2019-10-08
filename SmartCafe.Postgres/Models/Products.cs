using System;
using System.Collections.Generic;

namespace SmartCafe.Postgres.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderItems = new HashSet<OrderItems>();
            ProductCategories = new HashSet<ProductCategories>();
            ProductSubCategories = new HashSet<ProductSubCategories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? PriceWithVat { get; set; }
        public bool IsRecommended { get; set; }
        public bool IsPromo { get; set; }
        public string[] Allergens { get; set; }

        public virtual ICollection<OrderItems> OrderItems { get; set; }
        public virtual ICollection<ProductCategories> ProductCategories { get; set; }
        public virtual ICollection<ProductSubCategories> ProductSubCategories { get; set; }
    }
}
