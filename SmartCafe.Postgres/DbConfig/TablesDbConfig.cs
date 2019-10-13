using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartCafe.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCafe.Postgres.DbConfig
{
    public class TablesDbConfig : IEntityTypeConfiguration<Tables>
    {
        public void Configure(EntityTypeBuilder<Tables> builder)
        {
            builder.HasData(
                new Tables
                {
                    Id = 1,
                    Tag = "Sto br. 1",
                    Description = "Sto za nepušače",
                    IsInUse = false
                },
                new Tables
                {
                    Id = 2,
                    Tag = "Sto br. 2",
                    Description = "Sto za pušače",
                    IsInUse = false
                },
                new Tables
                {
                    Id = 3,
                    Tag = "Sto br. 3",
                    Description = "Sto za ručak",
                    IsInUse = false
                }
            );
        }
    }
}
