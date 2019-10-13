using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartCafe.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCafe.Postgres.DbConfig
{
    public class UsersDbConfig : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasData(
                new Users
                {
                    Id = 1,
                    Username = "mdarco",
                    Password = "$2a$10$yHj0aEM1PSZSGYfkQ3QvYe6REKDlnofPnfbUiVbfLIYnDj52WYiP6",
                    FullName = "Darko Milutinović",
                    Email = "dmilutinovic@gmail.com"
                }
            );
        }
    }
}
