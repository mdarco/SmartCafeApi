using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartCafe.Postgres.Migrations
{
    public partial class initialseedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tables",
                columns: new[] { "description", "is_in_use", "tag" },
                values: new object[,]
                {
                    { "Sto za nepušače", false, "Sto br. 1" },
                    { "Sto za pušače", false, "Sto br. 2" },
                    { "Sto za ručak", false, "Sto br. 3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
