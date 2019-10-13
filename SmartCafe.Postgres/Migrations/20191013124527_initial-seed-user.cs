using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SmartCafe.Postgres.Migrations
{
    public partial class initialseeduser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "created_at", "email", "full_name", "note", "password", "phone", "username" },
                values: new object[] { null, "dmilutinovic@gmail.com", "Darko Milutinović", null, "$2a$10$yHj0aEM1PSZSGYfkQ3QvYe6REKDlnofPnfbUiVbfLIYnDj52WYiP6", null, "mdarco" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string query = "delete from users where id = 1";
            migrationBuilder.Sql(query);
        }
    }
}
