using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartCafe.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCafe.Postgres.DbConfig
{
    public class ProductSubCategoriesDbConfig : IEntityTypeConfiguration<ProductSubCategories>
    {
        public void Configure(EntityTypeBuilder<ProductSubCategories> builder)
        {
            var faker = new Faker();

            for (int i = 1; i <= 100; i++)
            {
                builder.HasData(
                    new ProductSubCategories
                    {
                        ProductId = i,
                        SubCategoryId = faker.Random.Number(1, 12),
                        Note = faker.Random.String(10, 100)
                    }
                );
            }

            // let some products have two sub-categories
            for (int i = 1; i <= 100; i++)
            {
                var productId = faker.Random.Number(1, 100);

                builder.HasData(
                    new ProductSubCategories
                    {
                        ProductId = productId,
                        SubCategoryId = faker.Random.Number(1, 12),
                        Note = faker.Random.String(10, 100)
                    }
                );
            }
        }
    }
}
