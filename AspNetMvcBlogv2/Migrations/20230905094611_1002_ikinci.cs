using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetMvcBlogv2.Migrations
{
    /// <inheritdoc />
    public partial class _1002_ikinci : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("1e4e4dfc-07bc-410f-baf9-ded048b8a252"), new Guid("d2960b3b-aadf-479f-883c-55491b6225f1") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("66c1cd20-0a4a-481a-910e-dcca1c5d96f2"), new Guid("cde9c5e7-d458-4db5-8b01-2589a71c389b") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("6a042627-8985-4763-aef6-56fa415ad742"), new Guid("813a5718-6fd9-4112-b69e-ef6196404f79") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("6c05a676-b28a-4314-91e5-9540259e877d"), new Guid("90403af6-f8d0-41aa-be92-b9738b459a6f") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("ad8fc89b-96d6-4273-9194-cd2f164531d3"), new Guid("6bb590ff-dca2-4640-a423-be3cbbe24059") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("ad8fc89b-96d6-4273-9194-cd2f164531d3"), new Guid("813a5718-6fd9-4112-b69e-ef6196404f79") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("c7c91b0d-498a-4a98-8c52-fa9a4e18f15c"), new Guid("04625ab9-af73-4611-b7e7-2e6a478fca47") });

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: new Guid("850bf509-1fde-4bf3-9f86-6041c8e1d7e8"));

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: new Guid("d2f67ea6-54dc-453c-a9cc-a906480dc552"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("08bd775f-792a-4b33-9873-905a55d745a0"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("0f1066a3-a63e-4e2b-9d38-5f411cf8ffff"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("18cf0c92-2aa7-420b-b987-61926369dc73"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("1d3d1338-38bb-4fb9-8579-578265972843"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("30b3363a-9cb2-4f03-9aa0-d563e8c103b8"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("643b547c-5dca-4341-bf5d-d20255de4a53"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("a037335d-c653-4b37-91ef-53a6773831e9"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("ba061019-67d7-4736-92fa-c40fd56a083d"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("c9eed44d-1d2c-48dd-aaeb-6b47b27f5818"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("f701228c-5c24-4805-a899-11a08fbb2e90"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("238c0fbb-6adf-4548-a14b-cdcfe36dcd02"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("4715eff0-7f9e-4594-bc4c-657ed558480f"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("5a92e0ef-f095-477b-a43c-5944bfe0cb56"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("776e900e-dda9-4f3b-a2ec-13b02c1a90d4"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("cd6cb517-e54f-4048-8368-0dae6f07b3e9"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("e24ec3ba-00ea-4d55-a762-d1707aed594f"));

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: new Guid("258e8dae-d039-4799-80a8-0cb281ea4bc3"));

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: new Guid("6705d74d-fe2e-4113-8494-7e3f2574e2f4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("156ddce5-8e69-4ec2-b9bd-19e752837e92"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("25247edf-1c92-41ce-8de8-3188f39c6b2e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2537c73e-1aff-4d1e-975b-403d38a825b9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4ae8dec1-de44-4c07-b248-2c7a1e7c9edc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7c0ba92a-ef68-4e3a-a0f2-c02a23a3299a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("82603321-3a04-4777-8751-34ddf8d165f9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1e4e4dfc-07bc-410f-baf9-ded048b8a252"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("66c1cd20-0a4a-481a-910e-dcca1c5d96f2"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("6a042627-8985-4763-aef6-56fa415ad742"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("6c05a676-b28a-4314-91e5-9540259e877d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ad8fc89b-96d6-4273-9194-cd2f164531d3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c7c91b0d-498a-4a98-8c52-fa9a4e18f15c"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("04625ab9-af73-4611-b7e7-2e6a478fca47"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("6bb590ff-dca2-4640-a423-be3cbbe24059"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("813a5718-6fd9-4112-b69e-ef6196404f79"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("90403af6-f8d0-41aa-be92-b9738b459a6f"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("cde9c5e7-d458-4db5-8b01-2589a71c389b"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("d2960b3b-aadf-479f-883c-55491b6225f1"));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0245eafe-8a63-474d-94b3-9e19233344b0"), "Relationships" },
                    { new Guid("070ca9f3-5a93-404f-91dd-ff6abd4d0683"), "Sustainability" },
                    { new Guid("140b30a6-119b-4b6a-ada9-8117209ffd9d"), "Creativity" },
                    { new Guid("2eb53053-e03c-45be-811a-0c103d235d1c"), "Personal Growth" },
                    { new Guid("7b5f731a-7c6e-476c-bff8-34079fa706c4"), "Travel and Exploration" },
                    { new Guid("a8456cfb-c4eb-4f8f-9dc5-23e6cf5b30b8"), "Health and Fitness" }
                });

            migrationBuilder.InsertData(
                table: "Page",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { new Guid("5bbbc674-729c-462f-ad98-51919249b407"), "This is the contact page", "Contact" },
                    { new Guid("6954a1f1-c350-4367-9600-e0dc9f282ab0"), "This is the about us page", "About Us" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Content", "PublishedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0b0a00e8-814c-44de-a0c1-0dd5aa228043"), "Exploring new places broadens your horizons and enriches your life in ways you can't imagine. From the bustling streets of vibrant cities to the serene beauty of remote landscapes, every destination has a story to tell. So, pack your bags, embrace the adventure, and let the world be your teacher.", new DateTime(2023, 9, 5, 12, 46, 11, 835, DateTimeKind.Local).AddTicks(4766), "Second Post", new DateTime(2023, 9, 5, 12, 46, 11, 835, DateTimeKind.Local).AddTicks(4767) },
                    { new Guid("278ea442-3103-400b-8f07-a2cd37aa5127"), "Personal growth is a lifelong journey of self-discovery and self-improvement. It's about embracing change, learning from experiences, and continuously evolving into the best version of yourself. Remember, progress may be slow at times, but every step forward is a step closer to your goals.", new DateTime(2023, 9, 5, 12, 46, 11, 835, DateTimeKind.Local).AddTicks(4768), "Third Post", new DateTime(2023, 9, 5, 12, 46, 11, 835, DateTimeKind.Local).AddTicks(4768) },
                    { new Guid("4ae10166-39af-40fd-888a-f98af6a0491f"), "Strong and meaningful relationships are the cornerstone of a fulfilling life. Cultivate connections that are built on trust, communication, and mutual respect. These bonds will provide unwavering support and joy through life's ups and downs.", new DateTime(2023, 9, 5, 12, 46, 11, 835, DateTimeKind.Local).AddTicks(4770), "Forth Post", new DateTime(2023, 9, 5, 12, 46, 11, 835, DateTimeKind.Local).AddTicks(4770) },
                    { new Guid("567e6e99-bcab-4c9b-8ad2-e30be5613db4"), "Creativity knows no bounds, and it resides within each of us. Whether you express it through art, writing, music, or any other form, don't hesitate to let your imagination run wild. Your unique creative voice has the power to inspire, uplift, and change the world.", new DateTime(2023, 9, 5, 12, 46, 11, 835, DateTimeKind.Local).AddTicks(4771), "Fifth Post", new DateTime(2023, 9, 5, 12, 46, 11, 835, DateTimeKind.Local).AddTicks(4772) },
                    { new Guid("70f6ee74-0d24-44a0-8792-8cecbcac99df"), "Maintaining a healthy lifestyle goes beyond hitting the gym; it's about making mindful choices every day. Whether it's choosing nutritious foods or finding joy in outdoor activities, taking small steps can lead to significant improvements in your overall well-being. Remember, your journey to better health is a marathon, not a sprint.", new DateTime(2023, 9, 5, 12, 46, 11, 835, DateTimeKind.Local).AddTicks(4764), "First Post", new DateTime(2023, 9, 5, 12, 46, 11, 835, DateTimeKind.Local).AddTicks(4765) },
                    { new Guid("93068827-1f71-492e-a53e-e8e88c92fb04"), "The planet we call home needs our care and attention now more than ever. Embracing sustainable practices in our daily lives, from reducing waste to conserving energy, is not just a choice but a responsibility. Together, we can create a greener and healthier future for generations to come.", new DateTime(2023, 9, 5, 12, 46, 11, 835, DateTimeKind.Local).AddTicks(4773), "Sixst Post", new DateTime(2023, 9, 5, 12, 46, 11, 835, DateTimeKind.Local).AddTicks(4773) }
                });

            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("cb7825e0-6a91-46b7-b199-0919c676a6ce"), "MaxPostsPerPage", "10" },
                    { new Guid("dc982b2d-6fdf-4be7-897a-1cef03e17b9c"), "SiteName", "My Blog" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "Surname" },
                values: new object[,]
                {
                    { new Guid("0b8a1729-0321-4b82-963e-dceb77633d4e"), "test1@gmail.com", "user1", "123", "TEST" },
                    { new Guid("169d0b72-4f8f-4a00-9c08-a92b22073649"), "test5@gmail.com", "user5", "123", "TEST" },
                    { new Guid("64a1f3c8-ae74-4b0e-814a-65cdb49b7c1f"), "test2@gmail.com", "user2", "123", "TEST" },
                    { new Guid("75d4ad85-b9eb-484a-babc-debca518744b"), "test4@gmail.com", "user4", "123", "TEST" },
                    { new Guid("89385ee8-f953-4b2a-9f3c-4d4c81589a95"), "test3@gmail.com", "user3", "123", "TEST" },
                    { new Guid("9456a9bc-162e-4e87-bf98-13340f867bfb"), "test6@gmail.com", "user6", "123", "TEST" }
                });

            migrationBuilder.InsertData(
                table: "CategoryPost",
                columns: new[] { "CategoryId", "PostId", "Id" },
                values: new object[,]
                {
                    { new Guid("0245eafe-8a63-474d-94b3-9e19233344b0"), new Guid("4ae10166-39af-40fd-888a-f98af6a0491f"), new Guid("9fd16abc-bbd7-4e62-aa15-b9b609053048") },
                    { new Guid("070ca9f3-5a93-404f-91dd-ff6abd4d0683"), new Guid("93068827-1f71-492e-a53e-e8e88c92fb04"), new Guid("5a0e0cf0-d560-4036-a679-1c434717e7d0") },
                    { new Guid("140b30a6-119b-4b6a-ada9-8117209ffd9d"), new Guid("4ae10166-39af-40fd-888a-f98af6a0491f"), new Guid("58d85fc6-f7eb-4ae0-9d80-70c5534e9ca6") },
                    { new Guid("140b30a6-119b-4b6a-ada9-8117209ffd9d"), new Guid("567e6e99-bcab-4c9b-8ad2-e30be5613db4"), new Guid("c6a0c4da-9606-4610-9a65-106f3c5ab07d") },
                    { new Guid("2eb53053-e03c-45be-811a-0c103d235d1c"), new Guid("278ea442-3103-400b-8f07-a2cd37aa5127"), new Guid("7dd7fbdb-69ad-4484-870d-747f7cf094db") },
                    { new Guid("7b5f731a-7c6e-476c-bff8-34079fa706c4"), new Guid("0b0a00e8-814c-44de-a0c1-0dd5aa228043"), new Guid("9559b19d-7235-47e0-84e3-77627d857c75") },
                    { new Guid("a8456cfb-c4eb-4f8f-9dc5-23e6cf5b30b8"), new Guid("70f6ee74-0d24-44a0-8792-8cecbcac99df"), new Guid("b6f09a20-c223-4c98-9495-f61f1017ff68") }
                });

            migrationBuilder.InsertData(
                table: "PostComment",
                columns: new[] { "Id", "Content", "PostId" },
                values: new object[,]
                {
                    { new Guid("0bb2fce9-ea4c-4f8a-9a61-24620d993e9f"), "Your smile is absolutely radiant, lighting up the entire page!", new Guid("70f6ee74-0d24-44a0-8792-8cecbcac99df") },
                    { new Guid("1c5a89fd-ea17-4aad-90c2-90fd157a8bd3"), "Your face is a reflection of the sunshine in your heart.", new Guid("4ae10166-39af-40fd-888a-f98af6a0491f") },
                    { new Guid("48239661-1de0-4b78-8a57-724a923d71cb"), "Your expressions are a delightful addition to this blog!", new Guid("567e6e99-bcab-4c9b-8ad2-e30be5613db4") },
                    { new Guid("58764b8d-5654-447d-9d8f-c6a8bc10428f"), "Each picture tells a story of happiness and positivity.", new Guid("278ea442-3103-400b-8f07-a2cd37aa5127") },
                    { new Guid("62a24852-454c-40d2-857a-fbedfe5d34ef"), "Your face brightens up my day – thank you for sharing your joy!", new Guid("0b0a00e8-814c-44de-a0c1-0dd5aa228043") },
                    { new Guid("6bddd77d-3b13-4088-84c7-828a850b74c8"), "Your presence adds a touch of elegance to this blog.", new Guid("4ae10166-39af-40fd-888a-f98af6a0491f") },
                    { new Guid("b7fadc7f-21ea-499a-85ee-111ff3c35f29"), "What a charming face, your positivity is contagious!", new Guid("0b0a00e8-814c-44de-a0c1-0dd5aa228043") },
                    { new Guid("e9e137f2-0204-4d01-b382-d5d47da98949"), "You exude such warmth and kindness in every photo.", new Guid("278ea442-3103-400b-8f07-a2cd37aa5127") },
                    { new Guid("ee80e9af-ae59-4d1b-b09e-f863b688f542"), "A truly beautiful face that reflects an equally beautiful soul.", new Guid("4ae10166-39af-40fd-888a-f98af6a0491f") },
                    { new Guid("f550f07a-7c85-430f-9691-3b0596a9ec0f"), "You've got that perfect combination of grace and charm.", new Guid("93068827-1f71-492e-a53e-e8e88c92fb04") }
                });

            migrationBuilder.InsertData(
                table: "PostImage",
                columns: new[] { "Id", "ImageUrl", "PostId" },
                values: new object[,]
                {
                    { new Guid("132983cd-93c4-4c89-8117-cf11fd62714e"), "https://picsum.photos/id/15/150/200", new Guid("278ea442-3103-400b-8f07-a2cd37aa5127") },
                    { new Guid("7fbd2309-2ec7-4779-91ef-a8551e66983d"), "https://picsum.photos/id/14/150/200", new Guid("0b0a00e8-814c-44de-a0c1-0dd5aa228043") },
                    { new Guid("ad5d0884-632d-4766-8ccc-d7161d75a33d"), "https://picsum.photos/id/11/150/200", new Guid("0b0a00e8-814c-44de-a0c1-0dd5aa228043") },
                    { new Guid("be3b2171-6def-4370-84c3-47608179761e"), "https://picsum.photos/id/12/150/200", new Guid("278ea442-3103-400b-8f07-a2cd37aa5127") },
                    { new Guid("c01b423f-6205-4348-a3bd-f810c2bf8d8d"), "https://picsum.photos/id/10/150/200", new Guid("70f6ee74-0d24-44a0-8792-8cecbcac99df") },
                    { new Guid("debeb19e-3eaf-4408-b2d2-c31ce5106f86"), "https://picsum.photos/id/13/150/200", new Guid("70f6ee74-0d24-44a0-8792-8cecbcac99df") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("0245eafe-8a63-474d-94b3-9e19233344b0"), new Guid("4ae10166-39af-40fd-888a-f98af6a0491f") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("070ca9f3-5a93-404f-91dd-ff6abd4d0683"), new Guid("93068827-1f71-492e-a53e-e8e88c92fb04") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("140b30a6-119b-4b6a-ada9-8117209ffd9d"), new Guid("4ae10166-39af-40fd-888a-f98af6a0491f") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("140b30a6-119b-4b6a-ada9-8117209ffd9d"), new Guid("567e6e99-bcab-4c9b-8ad2-e30be5613db4") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("2eb53053-e03c-45be-811a-0c103d235d1c"), new Guid("278ea442-3103-400b-8f07-a2cd37aa5127") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("7b5f731a-7c6e-476c-bff8-34079fa706c4"), new Guid("0b0a00e8-814c-44de-a0c1-0dd5aa228043") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("a8456cfb-c4eb-4f8f-9dc5-23e6cf5b30b8"), new Guid("70f6ee74-0d24-44a0-8792-8cecbcac99df") });

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: new Guid("5bbbc674-729c-462f-ad98-51919249b407"));

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: new Guid("6954a1f1-c350-4367-9600-e0dc9f282ab0"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("0bb2fce9-ea4c-4f8a-9a61-24620d993e9f"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("1c5a89fd-ea17-4aad-90c2-90fd157a8bd3"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("48239661-1de0-4b78-8a57-724a923d71cb"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("58764b8d-5654-447d-9d8f-c6a8bc10428f"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("62a24852-454c-40d2-857a-fbedfe5d34ef"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("6bddd77d-3b13-4088-84c7-828a850b74c8"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("b7fadc7f-21ea-499a-85ee-111ff3c35f29"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("e9e137f2-0204-4d01-b382-d5d47da98949"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("ee80e9af-ae59-4d1b-b09e-f863b688f542"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("f550f07a-7c85-430f-9691-3b0596a9ec0f"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("132983cd-93c4-4c89-8117-cf11fd62714e"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("7fbd2309-2ec7-4779-91ef-a8551e66983d"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("ad5d0884-632d-4766-8ccc-d7161d75a33d"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("be3b2171-6def-4370-84c3-47608179761e"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("c01b423f-6205-4348-a3bd-f810c2bf8d8d"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("debeb19e-3eaf-4408-b2d2-c31ce5106f86"));

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: new Guid("cb7825e0-6a91-46b7-b199-0919c676a6ce"));

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: new Guid("dc982b2d-6fdf-4be7-897a-1cef03e17b9c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0b8a1729-0321-4b82-963e-dceb77633d4e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("169d0b72-4f8f-4a00-9c08-a92b22073649"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("64a1f3c8-ae74-4b0e-814a-65cdb49b7c1f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("75d4ad85-b9eb-484a-babc-debca518744b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("89385ee8-f953-4b2a-9f3c-4d4c81589a95"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9456a9bc-162e-4e87-bf98-13340f867bfb"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0245eafe-8a63-474d-94b3-9e19233344b0"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("070ca9f3-5a93-404f-91dd-ff6abd4d0683"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("140b30a6-119b-4b6a-ada9-8117209ffd9d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2eb53053-e03c-45be-811a-0c103d235d1c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7b5f731a-7c6e-476c-bff8-34079fa706c4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a8456cfb-c4eb-4f8f-9dc5-23e6cf5b30b8"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("0b0a00e8-814c-44de-a0c1-0dd5aa228043"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("278ea442-3103-400b-8f07-a2cd37aa5127"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("4ae10166-39af-40fd-888a-f98af6a0491f"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("567e6e99-bcab-4c9b-8ad2-e30be5613db4"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("70f6ee74-0d24-44a0-8792-8cecbcac99df"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("93068827-1f71-492e-a53e-e8e88c92fb04"));

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
        }
    }
}
