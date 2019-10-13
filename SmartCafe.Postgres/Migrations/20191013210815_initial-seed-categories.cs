using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartCafe.Postgres.Migrations
{
    public partial class initialseedcategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "name" },
                values: new object[,]
                {
                    { "Piće" },
                    { "Hrana" },
                    { "Cigarete" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
