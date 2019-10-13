using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartCafe.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCafe.Postgres.DbConfig
{
    public class SubCategoriesDbConfig : IEntityTypeConfiguration<SubCategories>
    {
        public void Configure(EntityTypeBuilder<SubCategories> builder)
        {
            builder.HasData(
                new SubCategories
                {
                    Id = 1,
                    Name = "Topli napici",
                    CategoryId = 1
                },
                new SubCategories
                {
                    Id = 2,
                    Name = "Vina",
                    CategoryId = 1
                },
                new SubCategories
                {
                    Id = 3,
                    Name = "Doručak",
                    CategoryId = 2
                },
                new SubCategories
                {
                    Id = 4,
                    Name = "Marloboro",
                    CategoryId = 3
                },
                new SubCategories
                {
                    Id = 5,
                    Name = "Piva",
                    CategoryId = 1
                },
                new SubCategories
                {
                    Id = 6,
                    Name = "Predjela",
                    CategoryId = 2
                },
                new SubCategories
                {
                    Id = 7,
                    Name = "Pall Mall",
                    CategoryId = 3
                },
                new SubCategories
                {
                    Id = 8,
                    Name = "Glavna jela",
                    CategoryId = 2
                },
                new SubCategories
                {
                    Id = 9,
                    Name = "Žestoka pića",
                    CategoryId = 1
                },
                new SubCategories
                {
                    Id = 10,
                    Name = "Beyalkoholna pića",
                    CategoryId = 1
                },
                new SubCategories
                {
                    Id = 11,
                    Name = "Desert",
                    CategoryId = 2
                },
                new SubCategories
                {
                    Id = 12,
                    Name = "Paste",
                    CategoryId = 2
                }
            );
        }
    }
}
