using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetMvcBlogv2.Persistence.Migrations
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
                    Content = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false)
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
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
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

            migrationBuilder.CreateTable(
                name: "PostComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_PostComment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("034801f8-e9b2-4a8f-b2eb-e03e1f6ff8e1"), "Travel and Exploration" },
                    { new Guid("23618acb-75d7-41a6-bed6-bfc7fee78c18"), "Personal Growth" },
                    { new Guid("2d1f2324-ded3-4b83-99d5-ab9b0c6559d1"), "Creativity" },
                    { new Guid("307f84b3-99b7-4a37-9547-7228aa6223c9"), "Relationships" },
                    { new Guid("c1dc111a-8bbf-4d62-9123-5182765d2fb9"), "Sustainability" },
                    { new Guid("c604a3eb-f541-4d39-8edd-7de18da5acba"), "Health and Fitness" }
                });

            migrationBuilder.InsertData(
                table: "Page",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { new Guid("4bd94b33-0899-41c2-8e76-1d9abe075032"), "Whether you have a question, feedback, or a partnership inquiry, our \"Contact\" page is the gateway to reach out to us. We're eager to hear your thoughts, answer your queries, and collaborate with like-minded individuals and organizations who share our passions.\r\n\r\nWe've designed our contact form to be user-friendly, ensuring that your message reaches us without any hassle. Your input is not just welcomed; it's highly appreciated, as it helps us improve and tailor our content to better serve your needs and interests.", "Contact" },
                    { new Guid("725e189a-b461-4a7d-ab6c-a28780aec6f2"), "The \"About Us\" page on our blogsite is a window into the heart and soul of our digital presence. It's the place where we introduce ourselves, sharing the story behind our passion and purpose. We're not just another website; we're a team of dedicated individuals with a common mission.", "About Us" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Content", "PublishedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0c0a78f4-00d8-4682-877d-cbf06977cbd1"), "Creativity knows no bounds, and it resides within each of us. Whether you express it through art, writing, music, or any other form, don't hesitate to let your imagination run wild. Your unique creative voice has the power to inspire, uplift, and change the world.", new DateTime(2023, 9, 20, 18, 58, 58, 766, DateTimeKind.Local).AddTicks(8942), "Fifth Post", new DateTime(2023, 9, 20, 18, 58, 58, 766, DateTimeKind.Local).AddTicks(8942) },
                    { new Guid("33840f1b-d0eb-4dd4-8277-04a61a150898"), "Exploring new places broadens your horizons and enriches your life in ways you can't imagine. From the bustling streets of vibrant cities to the serene beauty of remote landscapes, every destination has a story to tell. So, pack your bags, embrace the adventure, and let the world be your teacher.", new DateTime(2023, 9, 20, 18, 58, 58, 766, DateTimeKind.Local).AddTicks(8937), "Second Post", new DateTime(2023, 9, 20, 18, 58, 58, 766, DateTimeKind.Local).AddTicks(8937) },
                    { new Guid("46ad1642-b625-4689-b53a-9355cfe1b824"), "Strong and meaningful relationships are the cornerstone of a fulfilling life. Cultivate connections that are built on trust, communication, and mutual respect. These bonds will provide unwavering support and joy through life's ups and downs.", new DateTime(2023, 9, 20, 18, 58, 58, 766, DateTimeKind.Local).AddTicks(8940), "Forth Post", new DateTime(2023, 9, 20, 18, 58, 58, 766, DateTimeKind.Local).AddTicks(8940) },
                    { new Guid("8101323f-626a-47c7-a295-3fca9d09590d"), "Maintaining a healthy lifestyle goes beyond hitting the gym; it's about making mindful choices every day. Whether it's choosing nutritious foods or finding joy in outdoor activities, taking small steps can lead to significant improvements in your overall well-being. Remember, your journey to better health is a marathon, not a sprint.", new DateTime(2023, 9, 20, 18, 58, 58, 766, DateTimeKind.Local).AddTicks(8934), "First Post", new DateTime(2023, 9, 20, 18, 58, 58, 766, DateTimeKind.Local).AddTicks(8935) },
                    { new Guid("97edb7a7-5346-4bab-9023-4d48a7a756fd"), "The planet we call home needs our care and attention now more than ever. Embracing sustainable practices in our daily lives, from reducing waste to conserving energy, is not just a choice but a responsibility. Together, we can create a greener and healthier future for generations to come.", new DateTime(2023, 9, 20, 18, 58, 58, 766, DateTimeKind.Local).AddTicks(8943), "Sixst Post", new DateTime(2023, 9, 20, 18, 58, 58, 766, DateTimeKind.Local).AddTicks(8944) },
                    { new Guid("c5afaff4-d806-43cc-997f-58f340d7faf9"), "Personal growth is a lifelong journey of self-discovery and self-improvement. It's about embracing change, learning from experiences, and continuously evolving into the best version of yourself. Remember, progress may be slow at times, but every step forward is a step closer to your goals.", new DateTime(2023, 9, 20, 18, 58, 58, 766, DateTimeKind.Local).AddTicks(8938), "Third Post", new DateTime(2023, 9, 20, 18, 58, 58, 766, DateTimeKind.Local).AddTicks(8939) }
                });

            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("eb59074a-f0fa-43f7-8470-4ed8869eb586"), "MaxPostsPerPage", "10" },
                    { new Guid("ed0a893e-3c79-43fa-aff8-31197f61a2e6"), "SiteName", "My Blog" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "ProfilePictureURL", "Surname" },
                values: new object[,]
                {
                    { new Guid("25317e4f-56b3-4d34-a17a-a668dfd80345"), "test3@gmail.com", "user3", "123", "https://picsum.photos/id/823/100/100", "TEST" },
                    { new Guid("6f3e3f53-e87e-4e37-9567-d836f786152f"), "test5@gmail.com", "user5", "123", "https://picsum.photos/id/832/100/100", "TEST" },
                    { new Guid("78a232fe-ab35-4323-bd7a-cd1ac3f65079"), "test1@gmail.com", "user1", "123", "https://picsum.photos/id/804/100/100", "TEST" },
                    { new Guid("e571e092-cd21-4fbb-bc50-45692d33e1ba"), "test2@gmail.com", "user2", "123", "https://picsum.photos/id/807/100/100", "TEST" },
                    { new Guid("e823c791-543e-4aee-beee-6f4bcb7d8cc2"), "test4@gmail.com", "user4", "123", "https://picsum.photos/id/822/100/100", "TEST" },
                    { new Guid("f5dc9fd5-274d-41eb-b9d3-1ada33077d46"), "test6@gmail.com", "user6", "123", "https://picsum.photos/id/836/100/100", "TEST" }
                });

            migrationBuilder.InsertData(
                table: "CategoryPost",
                columns: new[] { "CategoryId", "PostId", "Id" },
                values: new object[,]
                {
                    { new Guid("034801f8-e9b2-4a8f-b2eb-e03e1f6ff8e1"), new Guid("33840f1b-d0eb-4dd4-8277-04a61a150898"), new Guid("5f2c9154-cfa0-44fb-b281-84268052af39") },
                    { new Guid("23618acb-75d7-41a6-bed6-bfc7fee78c18"), new Guid("c5afaff4-d806-43cc-997f-58f340d7faf9"), new Guid("3302ecde-94f0-467f-bdcf-f20868532c9c") },
                    { new Guid("2d1f2324-ded3-4b83-99d5-ab9b0c6559d1"), new Guid("0c0a78f4-00d8-4682-877d-cbf06977cbd1"), new Guid("972a4bf6-d94e-46d1-a569-c4c4926ae20f") },
                    { new Guid("2d1f2324-ded3-4b83-99d5-ab9b0c6559d1"), new Guid("46ad1642-b625-4689-b53a-9355cfe1b824"), new Guid("5ff9d30c-833c-429b-9f00-d38b65c68a04") },
                    { new Guid("307f84b3-99b7-4a37-9547-7228aa6223c9"), new Guid("46ad1642-b625-4689-b53a-9355cfe1b824"), new Guid("6607c70a-fb6e-4c71-9a7a-a95efc3666cc") },
                    { new Guid("c1dc111a-8bbf-4d62-9123-5182765d2fb9"), new Guid("97edb7a7-5346-4bab-9023-4d48a7a756fd"), new Guid("48e7aba1-8c6c-40ce-82c9-3f23a37d8650") },
                    { new Guid("c604a3eb-f541-4d39-8edd-7de18da5acba"), new Guid("8101323f-626a-47c7-a295-3fca9d09590d"), new Guid("371f0e5d-7705-43c9-97f5-52920f149566") }
                });

            migrationBuilder.InsertData(
                table: "PostComment",
                columns: new[] { "Id", "Content", "PostId", "UserId" },
                values: new object[,]
                {
                    { new Guid("075dd862-475d-47c3-adbf-430e5a5d8b52"), "Your face is a reflection of the sunshine in your heart.", new Guid("46ad1642-b625-4689-b53a-9355cfe1b824"), new Guid("f5dc9fd5-274d-41eb-b9d3-1ada33077d46") },
                    { new Guid("1435d1a9-8fab-462c-9745-dda0e2414a64"), "Each picture tells a story of happiness and positivity.", new Guid("c5afaff4-d806-43cc-997f-58f340d7faf9"), new Guid("78a232fe-ab35-4323-bd7a-cd1ac3f65079") },
                    { new Guid("1a20f5c3-411e-4778-b0ef-93ef3b8d92e2"), "You exude such warmth and kindness in every photo.", new Guid("c5afaff4-d806-43cc-997f-58f340d7faf9"), new Guid("e571e092-cd21-4fbb-bc50-45692d33e1ba") },
                    { new Guid("269e046f-5592-4953-9df5-11afd138d9c8"), "A truly beautiful face that reflects an equally beautiful soul.", new Guid("46ad1642-b625-4689-b53a-9355cfe1b824"), new Guid("25317e4f-56b3-4d34-a17a-a668dfd80345") },
                    { new Guid("924d3633-eba0-411e-ad66-85065cccae0b"), "Your face brightens up my day – thank you for sharing your joy!", new Guid("33840f1b-d0eb-4dd4-8277-04a61a150898"), new Guid("f5dc9fd5-274d-41eb-b9d3-1ada33077d46") },
                    { new Guid("972802ff-8778-486d-a9e5-8081d7ffa33f"), "Your presence adds a touch of elegance to this blog.", new Guid("46ad1642-b625-4689-b53a-9355cfe1b824"), new Guid("e571e092-cd21-4fbb-bc50-45692d33e1ba") },
                    { new Guid("9ec7da01-c4e0-45b3-96e9-50628a3bb45a"), "What a charming face, your positivity is contagious!", new Guid("33840f1b-d0eb-4dd4-8277-04a61a150898"), new Guid("78a232fe-ab35-4323-bd7a-cd1ac3f65079") },
                    { new Guid("aee8b630-a61e-4cf3-b419-6caae287b74e"), "Your expressions are a delightful addition to this blog!", new Guid("0c0a78f4-00d8-4682-877d-cbf06977cbd1"), new Guid("e823c791-543e-4aee-beee-6f4bcb7d8cc2") },
                    { new Guid("bb9a3eb7-5179-4d29-98f8-9114a1d1811c"), "Your smile is absolutely radiant, lighting up the entire page!", new Guid("8101323f-626a-47c7-a295-3fca9d09590d"), new Guid("f5dc9fd5-274d-41eb-b9d3-1ada33077d46") },
                    { new Guid("c99ff290-3a39-43f0-aa8c-d475ae0dd2da"), "You've got that perfect combination of grace and charm.", new Guid("97edb7a7-5346-4bab-9023-4d48a7a756fd"), new Guid("6f3e3f53-e87e-4e37-9567-d836f786152f") }
                });

            migrationBuilder.InsertData(
                table: "PostImage",
                columns: new[] { "Id", "ImageUrl", "PostId" },
                values: new object[,]
                {
                    { new Guid("1af9d053-b245-43f2-82ca-0950bcb6a434"), "https://picsum.photos/id/13/350/350", new Guid("46ad1642-b625-4689-b53a-9355cfe1b824") },
                    { new Guid("30b97d5f-33f0-499a-b9dc-33ae6a0dbe0c"), "https://picsum.photos/id/14/350/350", new Guid("0c0a78f4-00d8-4682-877d-cbf06977cbd1") },
                    { new Guid("82e7fa8f-85d2-4e77-a4b3-07247a931c1e"), "https://picsum.photos/id/11/350/350", new Guid("33840f1b-d0eb-4dd4-8277-04a61a150898") },
                    { new Guid("a2cbd1ac-f28b-4a98-99b4-1548bde993dd"), "https://picsum.photos/id/12/350/350", new Guid("c5afaff4-d806-43cc-997f-58f340d7faf9") },
                    { new Guid("ebba4f10-22fe-4daf-bb71-2e73031bd223"), "https://picsum.photos/id/10/350/350", new Guid("8101323f-626a-47c7-a295-3fca9d09590d") },
                    { new Guid("facee7f1-880f-4f97-b064-580d9dfef372"), "https://picsum.photos/id/15/350/350", new Guid("97edb7a7-5346-4bab-9023-4d48a7a756fd") }
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
                name: "IX_PostComment_UserId",
                table: "PostComment",
                column: "UserId");

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
                name: "Category");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Post");
        }
    }
}
