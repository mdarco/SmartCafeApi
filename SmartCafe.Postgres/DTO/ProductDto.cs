using System;
using System.Collections.Generic;

namespace SmartCafe.Postgres.DTO
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? PriceWithVat { get; set; }
        public bool IsRecommended { get; set; }
        public bool IsPromo { get; set; }
        public string[] Allergens { get; set; }

        public virtual List<string> Categories { get; set; }
        public virtual List<string> SubCategories { get; set; }
    }
}
