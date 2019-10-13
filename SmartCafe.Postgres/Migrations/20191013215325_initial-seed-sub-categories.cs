using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartCafe.Postgres.Migrations
{
    public partial class initialseedsubcategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "sub_categories",
                columns: new[] { "category_id", "name" },
                values: new object[,]
                {
                    { 1, "Topli napici" },
                    { 1, "Vina" },
                    { 2, "Doručak" },
                    { 3, "Marloboro" },
                    { 1, "Piva" },
                    { 2, "Predjela" },
                    { 3, "Pall Mall" },
                    { 2, "Glavna jela" },
                    { 1, "Žestoka pića" },
                    { 1, "Beyalkoholna pića" },
                    { 2, "Desert" },
                    { 2, "Paste" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "sub_categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "sub_categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "sub_categories",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "sub_categories",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "sub_categories",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "sub_categories",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "sub_categories",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "sub_categories",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "sub_categories",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "sub_categories",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "sub_categories",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "sub_categories",
                keyColumn: "id",
                keyValue: 12);
        }
    }
}
