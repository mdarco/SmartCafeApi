using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NodaTime;
using SmartCafe.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCafe.Postgres.DbConfig
{
    public class UserGroupsDbConfig : IEntityTypeConfiguration<UserGroups>
    {
        public void Configure(EntityTypeBuilder<UserGroups> builder)
        {
            builder.HasData(
                new UserGroups
                {
                    Id = 1,
                    Name = "ADMIN",
                    CreatedAt = DateTime.Now
                },
                new UserGroups
                {
                    Id = 2,
                    Name = "MENADZER",
                    CreatedAt = DateTime.Now
                },
                new UserGroups
                {
                    Id = 3,
                    Name = "KONOBAR",
                    CreatedAt = DateTime.Now
                }
            );
        }
    }
}
