using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetMvcBlogv2.Migrations
{
    /// <inheritdoc />
    public partial class _1002_CategoryCategoryPostPostIliskisi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bafd5f4e-e54e-4c43-8b4b-670eeb721426"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("be845d0d-94d6-460c-b8df-933881b2c081"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "Surname" },
                values: new object[,]
                {
                    { new Guid("52b6b699-dae4-4387-95c3-5f121e760dc1"), "aras@gmail.com", "Aras", "123", "Ment" },
                    { new Guid("eecf150e-1771-4964-b0a0-381650df1731"), "aksel@gmail.com", "Aksel", "321", "Ment" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("52b6b699-dae4-4387-95c3-5f121e760dc1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eecf150e-1771-4964-b0a0-381650df1731"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "Surname" },
                values: new object[,]
                {
                    { new Guid("bafd5f4e-e54e-4c43-8b4b-670eeb721426"), "aksel@gmail.com", "Aksel", "321", "Ment" },
                    { new Guid("be845d0d-94d6-460c-b8df-933881b2c081"), "aras@gmail.com", "Aras", "123", "Ment" }
                });
        }
    }
}
