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
            List<ProductSubCategories> productSubCategories = new List<ProductSubCategories>();

            var faker = new Faker();

            for (int i = 1; i <= 100; i++)
            {
                int subCategoryId = faker.Random.Number(1, 12);
                while (KeyExists(i, subCategoryId, productSubCategories))
                {
                    subCategoryId = faker.Random.Number(1, 12);
                }

                // Console.WriteLine(i.ToString() + " | " + subCategoryId.ToString());

                productSubCategories.Add(
                    new ProductSubCategories
                    {
                        ProductId = i,
                        SubCategoryId = subCategoryId,
                        Note = "Note"
                    }
                );
            }

            builder.HasData(productSubCategories.ToArray());
        }

        private bool KeyExists(int productId, int subCategoryId, List<ProductSubCategories> list)
        {
            var existing = list.Where(x => x.ProductId == productId && x.SubCategoryId == subCategoryId).FirstOrDefault();
            return existing != null;
        }
    }
}
