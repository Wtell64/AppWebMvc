using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetMvcBlogv2.Migrations
{
    /// <inheritdoc />
    public partial class _1003_idfixforphoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("05d31d49-b729-4513-8067-6cc1452d3cdb"), "Health and Fitness" },
                    { new Guid("0ad091ac-653a-4ef3-8be4-fb30614ebf70"), "Relationships" },
                    { new Guid("465fd53c-0682-4492-bc24-9a3aee30ec5d"), "Sustainability" },
                    { new Guid("739f78a6-2999-4751-beb6-8bc5315768e3"), "Travel and Exploration" },
                    { new Guid("bfb9894c-43e9-430b-a836-ba8b8ba9d23f"), "Personal Growth" },
                    { new Guid("fe60e619-0046-4c90-a904-bb43266b2268"), "Creativity" }
                });

            migrationBuilder.InsertData(
                table: "Page",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { new Guid("a8debc5b-d6b9-4680-805c-0c1b24b9a5ba"), "This is the contact page", "Contact" },
                    { new Guid("f04736c5-09fd-43b6-aca3-666ccb39f1f9"), "This is the about us page", "About Us" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Content", "PublishedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1e789c85-64d5-4439-a9b4-9f211d2e03ba"), "The planet we call home needs our care and attention now more than ever. Embracing sustainable practices in our daily lives, from reducing waste to conserving energy, is not just a choice but a responsibility. Together, we can create a greener and healthier future for generations to come.", new DateTime(2023, 9, 5, 12, 59, 57, 116, DateTimeKind.Local).AddTicks(9304), "Sixst Post", new DateTime(2023, 9, 5, 12, 59, 57, 116, DateTimeKind.Local).AddTicks(9304) },
                    { new Guid("5231a709-8d5a-4678-9c8a-74c9468c942a"), "Maintaining a healthy lifestyle goes beyond hitting the gym; it's about making mindful choices every day. Whether it's choosing nutritious foods or finding joy in outdoor activities, taking small steps can lead to significant improvements in your overall well-being. Remember, your journey to better health is a marathon, not a sprint.", new DateTime(2023, 9, 5, 12, 59, 57, 116, DateTimeKind.Local).AddTicks(9295), "First Post", new DateTime(2023, 9, 5, 12, 59, 57, 116, DateTimeKind.Local).AddTicks(9295) },
                    { new Guid("b3aec220-283d-4d21-962b-6e5a01a7cde4"), "Exploring new places broadens your horizons and enriches your life in ways you can't imagine. From the bustling streets of vibrant cities to the serene beauty of remote landscapes, every destination has a story to tell. So, pack your bags, embrace the adventure, and let the world be your teacher.", new DateTime(2023, 9, 5, 12, 59, 57, 116, DateTimeKind.Local).AddTicks(9297), "Second Post", new DateTime(2023, 9, 5, 12, 59, 57, 116, DateTimeKind.Local).AddTicks(9297) },
                    { new Guid("b9ca29cd-1e8f-478b-b0ff-26607d61ea3b"), "Personal growth is a lifelong journey of self-discovery and self-improvement. It's about embracing change, learning from experiences, and continuously evolving into the best version of yourself. Remember, progress may be slow at times, but every step forward is a step closer to your goals.", new DateTime(2023, 9, 5, 12, 59, 57, 116, DateTimeKind.Local).AddTicks(9299), "Third Post", new DateTime(2023, 9, 5, 12, 59, 57, 116, DateTimeKind.Local).AddTicks(9299) },
                    { new Guid("d5a438e6-c0ba-4c78-aa59-48adbe382f7b"), "Creativity knows no bounds, and it resides within each of us. Whether you express it through art, writing, music, or any other form, don't hesitate to let your imagination run wild. Your unique creative voice has the power to inspire, uplift, and change the world.", new DateTime(2023, 9, 5, 12, 59, 57, 116, DateTimeKind.Local).AddTicks(9302), "Fifth Post", new DateTime(2023, 9, 5, 12, 59, 57, 116, DateTimeKind.Local).AddTicks(9303) },
                    { new Guid("e9c21a84-38ca-4731-b54f-ebef6236a38b"), "Strong and meaningful relationships are the cornerstone of a fulfilling life. Cultivate connections that are built on trust, communication, and mutual respect. These bonds will provide unwavering support and joy through life's ups and downs.", new DateTime(2023, 9, 5, 12, 59, 57, 116, DateTimeKind.Local).AddTicks(9301), "Forth Post", new DateTime(2023, 9, 5, 12, 59, 57, 116, DateTimeKind.Local).AddTicks(9301) }
                });

            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("7709a9ee-d835-40e0-8d0a-09325fabcd19"), "SiteName", "My Blog" },
                    { new Guid("f6bde4dc-9358-4b74-b6df-0dfb17164a22"), "MaxPostsPerPage", "10" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "Surname" },
                values: new object[,]
                {
                    { new Guid("1d62a985-eeb7-41c6-a504-53b5f0b0f37d"), "test6@gmail.com", "user6", "123", "TEST" },
                    { new Guid("5ef26b65-a40f-40b1-abd5-230b3d3f0bab"), "test1@gmail.com", "user1", "123", "TEST" },
                    { new Guid("7dff4d57-0949-4702-8a71-b5708373d9bc"), "test4@gmail.com", "user4", "123", "TEST" },
                    { new Guid("d912d4b5-a0f0-4314-a17e-c4e16e034fee"), "test5@gmail.com", "user5", "123", "TEST" },
                    { new Guid("dddb4da9-974c-45b8-a1b5-5bc3b27bc459"), "test2@gmail.com", "user2", "123", "TEST" },
                    { new Guid("f8c75be2-f2bd-4dd3-99c3-e72db612122c"), "test3@gmail.com", "user3", "123", "TEST" }
                });

            migrationBuilder.InsertData(
                table: "CategoryPost",
                columns: new[] { "CategoryId", "PostId", "Id" },
                values: new object[,]
                {
                    { new Guid("05d31d49-b729-4513-8067-6cc1452d3cdb"), new Guid("5231a709-8d5a-4678-9c8a-74c9468c942a"), new Guid("847042bb-2715-4632-ad82-7b343d680310") },
                    { new Guid("0ad091ac-653a-4ef3-8be4-fb30614ebf70"), new Guid("e9c21a84-38ca-4731-b54f-ebef6236a38b"), new Guid("68615bb7-0cd2-458a-909c-37e2c72afea9") },
                    { new Guid("465fd53c-0682-4492-bc24-9a3aee30ec5d"), new Guid("1e789c85-64d5-4439-a9b4-9f211d2e03ba"), new Guid("8ed7d3c9-b178-4361-aea3-50b45819d299") },
                    { new Guid("739f78a6-2999-4751-beb6-8bc5315768e3"), new Guid("b3aec220-283d-4d21-962b-6e5a01a7cde4"), new Guid("d9cc4096-4fa3-4a54-b47e-70a9febe3098") },
                    { new Guid("bfb9894c-43e9-430b-a836-ba8b8ba9d23f"), new Guid("b9ca29cd-1e8f-478b-b0ff-26607d61ea3b"), new Guid("a4564f57-a597-41bd-ae17-7ebd877454fa") },
                    { new Guid("fe60e619-0046-4c90-a904-bb43266b2268"), new Guid("d5a438e6-c0ba-4c78-aa59-48adbe382f7b"), new Guid("cfa4bab3-9419-4b13-b4c2-e3047c033e9d") },
                    { new Guid("fe60e619-0046-4c90-a904-bb43266b2268"), new Guid("e9c21a84-38ca-4731-b54f-ebef6236a38b"), new Guid("643fa84c-fd59-421f-a650-a59d67b6f098") }
                });

            migrationBuilder.InsertData(
                table: "PostComment",
                columns: new[] { "Id", "Content", "PostId" },
                values: new object[,]
                {
                    { new Guid("13fce977-0d5d-4bff-b761-a5cba3774d27"), "A truly beautiful face that reflects an equally beautiful soul.", new Guid("e9c21a84-38ca-4731-b54f-ebef6236a38b") },
                    { new Guid("5b7b9534-51d4-499d-a8f6-db7b216bed2a"), "Your smile is absolutely radiant, lighting up the entire page!", new Guid("5231a709-8d5a-4678-9c8a-74c9468c942a") },
                    { new Guid("62503d1b-7fbe-488f-aa4d-aedc964dbd53"), "Your presence adds a touch of elegance to this blog.", new Guid("e9c21a84-38ca-4731-b54f-ebef6236a38b") },
                    { new Guid("7850df2d-6fb2-4c57-93aa-0c8b52386d44"), "Your expressions are a delightful addition to this blog!", new Guid("d5a438e6-c0ba-4c78-aa59-48adbe382f7b") },
                    { new Guid("878b8310-afec-4bf5-b8fd-8567e40804b6"), "You've got that perfect combination of grace and charm.", new Guid("1e789c85-64d5-4439-a9b4-9f211d2e03ba") },
                    { new Guid("a6c917cf-7abc-48d3-a60e-070c550d798d"), "Your face is a reflection of the sunshine in your heart.", new Guid("e9c21a84-38ca-4731-b54f-ebef6236a38b") },
                    { new Guid("c618dc24-59a2-483c-ae1f-4df810774728"), "You exude such warmth and kindness in every photo.", new Guid("b9ca29cd-1e8f-478b-b0ff-26607d61ea3b") },
                    { new Guid("da78a06e-a6bc-4995-8f59-5252aa096b09"), "What a charming face, your positivity is contagious!", new Guid("b3aec220-283d-4d21-962b-6e5a01a7cde4") },
                    { new Guid("eb320f10-ae64-4b88-b863-c6901192df84"), "Each picture tells a story of happiness and positivity.", new Guid("b9ca29cd-1e8f-478b-b0ff-26607d61ea3b") },
                    { new Guid("f37579f6-f1f2-4865-8b55-1a709f824c55"), "Your face brightens up my day – thank you for sharing your joy!", new Guid("b3aec220-283d-4d21-962b-6e5a01a7cde4") }
                });

            migrationBuilder.InsertData(
                table: "PostImage",
                columns: new[] { "Id", "ImageUrl", "PostId" },
                values: new object[,]
                {
                    { new Guid("4485b101-5b92-420c-99cf-dbe09204b683"), "https://picsum.photos/id/12/150/200", new Guid("b9ca29cd-1e8f-478b-b0ff-26607d61ea3b") },
                    { new Guid("47edab9a-8188-4777-8562-de95a31bf9fd"), "https://picsum.photos/id/10/150/200", new Guid("5231a709-8d5a-4678-9c8a-74c9468c942a") },
                    { new Guid("89aacb61-a26c-4c99-9e05-6fe55e02b29c"), "https://picsum.photos/id/14/150/200", new Guid("d5a438e6-c0ba-4c78-aa59-48adbe382f7b") },
                    { new Guid("a76a7c43-2cdd-4c7e-89f0-176101288f79"), "https://picsum.photos/id/15/150/200", new Guid("1e789c85-64d5-4439-a9b4-9f211d2e03ba") },
                    { new Guid("b89b65c9-5984-4990-aa14-d47503b85be9"), "https://picsum.photos/id/13/150/200", new Guid("e9c21a84-38ca-4731-b54f-ebef6236a38b") },
                    { new Guid("d91f560d-a86e-41ba-9d2a-3bccfc6023cc"), "https://picsum.photos/id/11/150/200", new Guid("b3aec220-283d-4d21-962b-6e5a01a7cde4") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("05d31d49-b729-4513-8067-6cc1452d3cdb"), new Guid("5231a709-8d5a-4678-9c8a-74c9468c942a") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("0ad091ac-653a-4ef3-8be4-fb30614ebf70"), new Guid("e9c21a84-38ca-4731-b54f-ebef6236a38b") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("465fd53c-0682-4492-bc24-9a3aee30ec5d"), new Guid("1e789c85-64d5-4439-a9b4-9f211d2e03ba") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("739f78a6-2999-4751-beb6-8bc5315768e3"), new Guid("b3aec220-283d-4d21-962b-6e5a01a7cde4") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("bfb9894c-43e9-430b-a836-ba8b8ba9d23f"), new Guid("b9ca29cd-1e8f-478b-b0ff-26607d61ea3b") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("fe60e619-0046-4c90-a904-bb43266b2268"), new Guid("d5a438e6-c0ba-4c78-aa59-48adbe382f7b") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("fe60e619-0046-4c90-a904-bb43266b2268"), new Guid("e9c21a84-38ca-4731-b54f-ebef6236a38b") });

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: new Guid("a8debc5b-d6b9-4680-805c-0c1b24b9a5ba"));

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: new Guid("f04736c5-09fd-43b6-aca3-666ccb39f1f9"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("13fce977-0d5d-4bff-b761-a5cba3774d27"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("5b7b9534-51d4-499d-a8f6-db7b216bed2a"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("62503d1b-7fbe-488f-aa4d-aedc964dbd53"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("7850df2d-6fb2-4c57-93aa-0c8b52386d44"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("878b8310-afec-4bf5-b8fd-8567e40804b6"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("a6c917cf-7abc-48d3-a60e-070c550d798d"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("c618dc24-59a2-483c-ae1f-4df810774728"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("da78a06e-a6bc-4995-8f59-5252aa096b09"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("eb320f10-ae64-4b88-b863-c6901192df84"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("f37579f6-f1f2-4865-8b55-1a709f824c55"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("4485b101-5b92-420c-99cf-dbe09204b683"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("47edab9a-8188-4777-8562-de95a31bf9fd"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("89aacb61-a26c-4c99-9e05-6fe55e02b29c"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("a76a7c43-2cdd-4c7e-89f0-176101288f79"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("b89b65c9-5984-4990-aa14-d47503b85be9"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("d91f560d-a86e-41ba-9d2a-3bccfc6023cc"));

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: new Guid("7709a9ee-d835-40e0-8d0a-09325fabcd19"));

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: new Guid("f6bde4dc-9358-4b74-b6df-0dfb17164a22"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1d62a985-eeb7-41c6-a504-53b5f0b0f37d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5ef26b65-a40f-40b1-abd5-230b3d3f0bab"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7dff4d57-0949-4702-8a71-b5708373d9bc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d912d4b5-a0f0-4314-a17e-c4e16e034fee"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dddb4da9-974c-45b8-a1b5-5bc3b27bc459"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f8c75be2-f2bd-4dd3-99c3-e72db612122c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("05d31d49-b729-4513-8067-6cc1452d3cdb"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("0ad091ac-653a-4ef3-8be4-fb30614ebf70"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("465fd53c-0682-4492-bc24-9a3aee30ec5d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("739f78a6-2999-4751-beb6-8bc5315768e3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("bfb9894c-43e9-430b-a836-ba8b8ba9d23f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("fe60e619-0046-4c90-a904-bb43266b2268"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("1e789c85-64d5-4439-a9b4-9f211d2e03ba"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("5231a709-8d5a-4678-9c8a-74c9468c942a"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("b3aec220-283d-4d21-962b-6e5a01a7cde4"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("b9ca29cd-1e8f-478b-b0ff-26607d61ea3b"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("d5a438e6-c0ba-4c78-aa59-48adbe382f7b"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("e9c21a84-38ca-4731-b54f-ebef6236a38b"));

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
    }
}
