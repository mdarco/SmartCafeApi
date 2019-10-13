using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartCafe.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCafe.Postgres.DbConfig
{
    public class CategoriesDbConfig : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasData(
                new Categories
                {
                    Id = 1,
                    Name = "Piće"
                },
                new Categories
                {
                    Id = 2,
                    Name = "Hrana"
                },
                new Categories
                {
                    Id = 3,
                    Name = "Cigarete"
                }
            );
        }
    }
}
