using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartCafe.Postgres.Migrations
{
    public partial class initialseedusergroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "user_groups",
                columns: new[] { "created_at", "name" },
                values: new object[,]
                {
                    { new DateTime(2019, 10, 13, 23, 1, 17, 499, DateTimeKind.Local).AddTicks(8490), "ADMIN" },
                    { new DateTime(2019, 10, 13, 23, 1, 17, 502, DateTimeKind.Local).AddTicks(6533), "MENADZER" },
                    { new DateTime(2019, 10, 13, 23, 1, 17, 502, DateTimeKind.Local).AddTicks(6593), "KONOBAR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user_groups",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "user_groups",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "user_groups",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
