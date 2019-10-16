using System;
using System.Collections.Generic;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartCafe.Postgres.Models;

namespace SmartCafe.Postgres.DbConfig
{
    public class ProductsDbConfig : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            var allergens = new List<string> { "kikiriki", "lešnik", "badem" };

            int productId = 1;

            var products = new Faker<Products>()
                .StrictMode(true)
                .RuleFor(p => p.Id, r => productId++)
                .RuleFor(p => p.Allergens, r => r.Random.ListItems<string>(allergens))
                .RuleFor(p => p.Name, r => r.Commerce.ProductName())
                .RuleFor(p => p.Description, r => r.Random.Words())
                .RuleFor(p => p.PriceWithVat, r => r.Random.Decimal(0, 1000))
                .RuleFor(p => p.IsRecommended, r => r.Random.Bool())
                .RuleFor(p => p.IsPromo, r => r.Random.Bool());

            var productsArray = products.Generate(100);

            builder.HasData(productsArray);
        }
    }
}
