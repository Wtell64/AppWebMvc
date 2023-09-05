using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetMvcBlogv2.Migrations
{
    /// <inheritdoc />
    public partial class _1001_ilk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

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
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPost",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPost", x => new { x.CategoryId, x.PostId });
                    table.ForeignKey(
                        name: "FK_CategoryPost_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPost_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1e4e4dfc-07bc-410f-baf9-ded048b8a252"), "Travel and Exploration" },
                    { new Guid("66c1cd20-0a4a-481a-910e-dcca1c5d96f2"), "Health and Fitness" },
                    { new Guid("6a042627-8985-4763-aef6-56fa415ad742"), "Relationships" },
                    { new Guid("6c05a676-b28a-4314-91e5-9540259e877d"), "Sustainability" },
                    { new Guid("ad8fc89b-96d6-4273-9194-cd2f164531d3"), "Creativity" },
                    { new Guid("c7c91b0d-498a-4a98-8c52-fa9a4e18f15c"), "Personal Growth" }
                });

            migrationBuilder.InsertData(
                table: "Page",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { new Guid("850bf509-1fde-4bf3-9f86-6041c8e1d7e8"), "This is the about us page", "About Us" },
                    { new Guid("d2f67ea6-54dc-453c-a9cc-a906480dc552"), "This is the contact page", "Contact" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Content", "PublishedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04625ab9-af73-4611-b7e7-2e6a478fca47"), "Personal growth is a lifelong journey of self-discovery and self-improvement. It's about embracing change, learning from experiences, and continuously evolving into the best version of yourself. Remember, progress may be slow at times, but every step forward is a step closer to your goals.", new DateTime(2023, 9, 4, 22, 47, 50, 220, DateTimeKind.Local).AddTicks(2395), "Third Post", new DateTime(2023, 9, 4, 22, 47, 50, 220, DateTimeKind.Local).AddTicks(2395) },
                    { new Guid("6bb590ff-dca2-4640-a423-be3cbbe24059"), "Creativity knows no bounds, and it resides within each of us. Whether you express it through art, writing, music, or any other form, don't hesitate to let your imagination run wild. Your unique creative voice has the power to inspire, uplift, and change the world.", new DateTime(2023, 9, 4, 22, 47, 50, 220, DateTimeKind.Local).AddTicks(2398), "Fifth Post", new DateTime(2023, 9, 4, 22, 47, 50, 220, DateTimeKind.Local).AddTicks(2399) },
                    { new Guid("813a5718-6fd9-4112-b69e-ef6196404f79"), "Strong and meaningful relationships are the cornerstone of a fulfilling life. Cultivate connections that are built on trust, communication, and mutual respect. These bonds will provide unwavering support and joy through life's ups and downs.", new DateTime(2023, 9, 4, 22, 47, 50, 220, DateTimeKind.Local).AddTicks(2397), "Forth Post", new DateTime(2023, 9, 4, 22, 47, 50, 220, DateTimeKind.Local).AddTicks(2397) },
                    { new Guid("90403af6-f8d0-41aa-be92-b9738b459a6f"), "The planet we call home needs our care and attention now more than ever. Embracing sustainable practices in our daily lives, from reducing waste to conserving energy, is not just a choice but a responsibility. Together, we can create a greener and healthier future for generations to come.", new DateTime(2023, 9, 4, 22, 47, 50, 220, DateTimeKind.Local).AddTicks(2400), "Sixst Post", new DateTime(2023, 9, 4, 22, 47, 50, 220, DateTimeKind.Local).AddTicks(2401) },
                    { new Guid("cde9c5e7-d458-4db5-8b01-2589a71c389b"), "Maintaining a healthy lifestyle goes beyond hitting the gym; it's about making mindful choices every day. Whether it's choosing nutritious foods or finding joy in outdoor activities, taking small steps can lead to significant improvements in your overall well-being. Remember, your journey to better health is a marathon, not a sprint.", new DateTime(2023, 9, 4, 22, 47, 50, 220, DateTimeKind.Local).AddTicks(2391), "First Post", new DateTime(2023, 9, 4, 22, 47, 50, 220, DateTimeKind.Local).AddTicks(2392) },
                    { new Guid("d2960b3b-aadf-479f-883c-55491b6225f1"), "Exploring new places broadens your horizons and enriches your life in ways you can't imagine. From the bustling streets of vibrant cities to the serene beauty of remote landscapes, every destination has a story to tell. So, pack your bags, embrace the adventure, and let the world be your teacher.", new DateTime(2023, 9, 4, 22, 47, 50, 220, DateTimeKind.Local).AddTicks(2393), "Second Post", new DateTime(2023, 9, 4, 22, 47, 50, 220, DateTimeKind.Local).AddTicks(2394) }
                });

            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("258e8dae-d039-4799-80a8-0cb281ea4bc3"), "SiteName", "My Blog" },
                    { new Guid("6705d74d-fe2e-4113-8494-7e3f2574e2f4"), "MaxPostsPerPage", "10" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "Surname" },
                values: new object[,]
                {
                    { new Guid("156ddce5-8e69-4ec2-b9bd-19e752837e92"), "test1@gmail.com", "user1", "123", "TEST" },
                    { new Guid("25247edf-1c92-41ce-8de8-3188f39c6b2e"), "test2@gmail.com", "user2", "123", "TEST" },
                    { new Guid("2537c73e-1aff-4d1e-975b-403d38a825b9"), "test4@gmail.com", "user4", "123", "TEST" },
                    { new Guid("4ae8dec1-de44-4c07-b248-2c7a1e7c9edc"), "test3@gmail.com", "user3", "123", "TEST" },
                    { new Guid("7c0ba92a-ef68-4e3a-a0f2-c02a23a3299a"), "test5@gmail.com", "user5", "123", "TEST" },
                    { new Guid("82603321-3a04-4777-8751-34ddf8d165f9"), "test6@gmail.com", "user6", "123", "TEST" }
                });

            migrationBuilder.InsertData(
                table: "CategoryPost",
                columns: new[] { "CategoryId", "PostId", "Id" },
                values: new object[,]
                {
                    { new Guid("1e4e4dfc-07bc-410f-baf9-ded048b8a252"), new Guid("d2960b3b-aadf-479f-883c-55491b6225f1"), new Guid("42099c9a-1614-488a-be70-01cf1f98e165") },
                    { new Guid("66c1cd20-0a4a-481a-910e-dcca1c5d96f2"), new Guid("cde9c5e7-d458-4db5-8b01-2589a71c389b"), new Guid("9c255dde-5adb-4f70-8e1a-bdf02f29b2e7") },
                    { new Guid("6a042627-8985-4763-aef6-56fa415ad742"), new Guid("813a5718-6fd9-4112-b69e-ef6196404f79"), new Guid("0979ce47-3958-48ef-b7fa-9d07f48f4003") },
                    { new Guid("6c05a676-b28a-4314-91e5-9540259e877d"), new Guid("90403af6-f8d0-41aa-be92-b9738b459a6f"), new Guid("d0be02b1-5fe7-4efa-8655-7572494272a7") },
                    { new Guid("ad8fc89b-96d6-4273-9194-cd2f164531d3"), new Guid("6bb590ff-dca2-4640-a423-be3cbbe24059"), new Guid("bf398100-8a52-4963-90cc-84c3c9d25945") },
                    { new Guid("ad8fc89b-96d6-4273-9194-cd2f164531d3"), new Guid("813a5718-6fd9-4112-b69e-ef6196404f79"), new Guid("ba03d5ae-87b1-4e94-9063-a6b8bde99c4c") },
                    { new Guid("c7c91b0d-498a-4a98-8c52-fa9a4e18f15c"), new Guid("04625ab9-af73-4611-b7e7-2e6a478fca47"), new Guid("283a9ada-19b7-40a2-bf04-9403b4613fa9") }
                });

            migrationBuilder.InsertData(
                table: "PostComment",
                columns: new[] { "Id", "Content", "PostId" },
                values: new object[,]
                {
                    { new Guid("08bd775f-792a-4b33-9873-905a55d745a0"), "Your face is a reflection of the sunshine in your heart.", new Guid("813a5718-6fd9-4112-b69e-ef6196404f79") },
                    { new Guid("0f1066a3-a63e-4e2b-9d38-5f411cf8ffff"), "You exude such warmth and kindness in every photo.", new Guid("04625ab9-af73-4611-b7e7-2e6a478fca47") },
                    { new Guid("18cf0c92-2aa7-420b-b987-61926369dc73"), "You've got that perfect combination of grace and charm.", new Guid("90403af6-f8d0-41aa-be92-b9738b459a6f") },
                    { new Guid("1d3d1338-38bb-4fb9-8579-578265972843"), "Your face brightens up my day – thank you for sharing your joy!", new Guid("d2960b3b-aadf-479f-883c-55491b6225f1") },
                    { new Guid("30b3363a-9cb2-4f03-9aa0-d563e8c103b8"), "Your expressions are a delightful addition to this blog!", new Guid("6bb590ff-dca2-4640-a423-be3cbbe24059") },
                    { new Guid("643b547c-5dca-4341-bf5d-d20255de4a53"), "A truly beautiful face that reflects an equally beautiful soul.", new Guid("813a5718-6fd9-4112-b69e-ef6196404f79") },
                    { new Guid("a037335d-c653-4b37-91ef-53a6773831e9"), "Your presence adds a touch of elegance to this blog.", new Guid("813a5718-6fd9-4112-b69e-ef6196404f79") },
                    { new Guid("ba061019-67d7-4736-92fa-c40fd56a083d"), "What a charming face, your positivity is contagious!", new Guid("d2960b3b-aadf-479f-883c-55491b6225f1") },
                    { new Guid("c9eed44d-1d2c-48dd-aaeb-6b47b27f5818"), "Your smile is absolutely radiant, lighting up the entire page!", new Guid("cde9c5e7-d458-4db5-8b01-2589a71c389b") },
                    { new Guid("f701228c-5c24-4805-a899-11a08fbb2e90"), "Each picture tells a story of happiness and positivity.", new Guid("04625ab9-af73-4611-b7e7-2e6a478fca47") }
                });

            migrationBuilder.InsertData(
                table: "PostImage",
                columns: new[] { "Id", "ImageUrl", "PostId" },
                values: new object[,]
                {
                    { new Guid("238c0fbb-6adf-4548-a14b-cdcfe36dcd02"), "https://picsum.photos/id/14/200/300", new Guid("d2960b3b-aadf-479f-883c-55491b6225f1") },
                    { new Guid("4715eff0-7f9e-4594-bc4c-657ed558480f"), "https://picsum.photos/id/10/200/300", new Guid("cde9c5e7-d458-4db5-8b01-2589a71c389b") },
                    { new Guid("5a92e0ef-f095-477b-a43c-5944bfe0cb56"), "https://picsum.photos/id/15/200/300", new Guid("04625ab9-af73-4611-b7e7-2e6a478fca47") },
                    { new Guid("776e900e-dda9-4f3b-a2ec-13b02c1a90d4"), "https://picsum.photos/id/13/200/300", new Guid("cde9c5e7-d458-4db5-8b01-2589a71c389b") },
                    { new Guid("cd6cb517-e54f-4048-8368-0dae6f07b3e9"), "https://picsum.photos/id/12/200/300", new Guid("04625ab9-af73-4611-b7e7-2e6a478fca47") },
                    { new Guid("e24ec3ba-00ea-4d55-a762-d1707aed594f"), "https://picsum.photos/id/11/200/300", new Guid("d2960b3b-aadf-479f-883c-55491b6225f1") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPost_PostId",
                table: "CategoryPost",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_PostId",
                table: "PostComment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostImage_PostId",
                table: "PostImage",
                column: "PostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryPost");

            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DropTable(
                name: "PostComment");

            migrationBuilder.DropTable(
                name: "PostImage");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Post");
        }
    }
}
