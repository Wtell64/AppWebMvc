using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetMvcBlogv2.Migrations
{
    /// <inheritdoc />
    public partial class _1004_Restoftherelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("95fac4d7-7a43-4b15-9858-a0ac9ee7c8ea"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a27f1bff-91e1-49d9-8c30-4832ffcdca03"));

            migrationBuilder.CreateTable(
                name: "Page",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostComment_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostImage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostImage_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Setting_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1bcad46b-be88-491f-8f02-8651e2d86296"), new DateTime(2023, 8, 23, 15, 24, 17, 969, DateTimeKind.Local).AddTicks(5219), "Cooking News", "Cooking", "Cook", new DateTime(2023, 8, 23, 15, 24, 17, 969, DateTimeKind.Local).AddTicks(5228) },
                    { new Guid("40bb28d3-29d1-4ca7-a563-4a5aaac7e7eb"), new DateTime(2023, 8, 23, 15, 24, 17, 969, DateTimeKind.Local).AddTicks(5214), "Technological News", "Technology", "Tech", new DateTime(2023, 8, 23, 15, 24, 17, 969, DateTimeKind.Local).AddTicks(5217) }
                });

            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "Id", "Name", "UserId", "Value" },
                values: new object[] { new Guid("85c981f6-9a5b-44cc-baa6-4e9fca6b32a1"), "Admin", null, "True" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "Surname" },
                values: new object[,]
                {
                    { new Guid("2c61bd7c-5924-48b8-907e-ddb7eb972d86"), "aksel@gmail.com", "Aksel", "321", "Ment" },
                    { new Guid("a8cfa872-d534-4aa1-b9a9-c2e7c921ba0b"), "aras@gmail.com", "Aras", "123", "Ment" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_PostId",
                table: "PostComment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostImage_PostId",
                table: "PostImage",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Setting_UserId",
                table: "Setting",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DropTable(
                name: "PostComment");

            migrationBuilder.DropTable(
                name: "PostImage");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1bcad46b-be88-491f-8f02-8651e2d86296"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("40bb28d3-29d1-4ca7-a563-4a5aaac7e7eb"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2c61bd7c-5924-48b8-907e-ddb7eb972d86"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a8cfa872-d534-4aa1-b9a9-c2e7c921ba0b"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "Surname" },
                values: new object[,]
                {
                    { new Guid("95fac4d7-7a43-4b15-9858-a0ac9ee7c8ea"), "aksel@gmail.com", "Aksel", "321", "Ment" },
                    { new Guid("a27f1bff-91e1-49d9-8c30-4832ffcdca03"), "aras@gmail.com", "Aras", "123", "Ment" }
                });
        }
    }
}
