using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetMvcBlogv2.Migrations
{
    /// <inheritdoc />
    public partial class _1003_updatetouser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePictureURL",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "PostComment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Page",
                type: "nvarchar(1500)",
                maxLength: 1500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("22843cd0-8286-451b-a42b-c7dae95e3243"), "Health and Fitness" },
                    { new Guid("33cdb6c1-df5b-41c9-b15b-d4067f003a1f"), "Creativity" },
                    { new Guid("46162259-83ba-464d-9b91-eac6d748e46b"), "Relationships" },
                    { new Guid("8c287da9-6b3a-4d5b-bfcc-fa3d6a2b1f79"), "Sustainability" },
                    { new Guid("9b4434c7-8da7-4bf6-ab63-5c1a8a18c5de"), "Personal Growth" },
                    { new Guid("c72f01da-b1b0-4ba2-943d-6934bb912a8e"), "Travel and Exploration" }
                });

            migrationBuilder.InsertData(
                table: "Page",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { new Guid("ba59d327-153e-4592-b468-1b1561688288"), "Whether you have a question, feedback, or a partnership inquiry, our \"Contact\" page is the gateway to reach out to us. We're eager to hear your thoughts, answer your queries, and collaborate with like-minded individuals and organizations who share our passions.\r\n\r\nWe've designed our contact form to be user-friendly, ensuring that your message reaches us without any hassle. Your input is not just welcomed; it's highly appreciated, as it helps us improve and tailor our content to better serve your needs and interests.", "Contact" },
                    { new Guid("d250ce11-4f06-408b-ae7a-2d185c90429f"), "The \"About Us\" page on our blogsite is a window into the heart and soul of our digital presence. It's the place where we introduce ourselves, sharing the story behind our passion and purpose. We're not just another website; we're a team of dedicated individuals with a common mission.", "About Us" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Content", "PublishedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0a1fefbc-e4c4-488e-a57c-2aa79bdc09fe"), "Personal growth is a lifelong journey of self-discovery and self-improvement. It's about embracing change, learning from experiences, and continuously evolving into the best version of yourself. Remember, progress may be slow at times, but every step forward is a step closer to your goals.", new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5017), "Third Post", new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5017) },
                    { new Guid("156443ea-bfbe-4ee0-b0b3-01fafae69be2"), "Maintaining a healthy lifestyle goes beyond hitting the gym; it's about making mindful choices every day. Whether it's choosing nutritious foods or finding joy in outdoor activities, taking small steps can lead to significant improvements in your overall well-being. Remember, your journey to better health is a marathon, not a sprint.", new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5013), "First Post", new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5014) },
                    { new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e"), "Strong and meaningful relationships are the cornerstone of a fulfilling life. Cultivate connections that are built on trust, communication, and mutual respect. These bonds will provide unwavering support and joy through life's ups and downs.", new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5019), "Forth Post", new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5020) },
                    { new Guid("a3cc8e5b-39a1-4818-81c9-ff1cfb12a1df"), "Exploring new places broadens your horizons and enriches your life in ways you can't imagine. From the bustling streets of vibrant cities to the serene beauty of remote landscapes, every destination has a story to tell. So, pack your bags, embrace the adventure, and let the world be your teacher.", new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5015), "Second Post", new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5016) },
                    { new Guid("d1c6e166-cc78-4ce7-b7ae-86b4b4cb01cc"), "The planet we call home needs our care and attention now more than ever. Embracing sustainable practices in our daily lives, from reducing waste to conserving energy, is not just a choice but a responsibility. Together, we can create a greener and healthier future for generations to come.", new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5022), "Sixst Post", new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5023) },
                    { new Guid("f718ef9e-83e7-4413-a6bb-591b2ee9f256"), "Creativity knows no bounds, and it resides within each of us. Whether you express it through art, writing, music, or any other form, don't hesitate to let your imagination run wild. Your unique creative voice has the power to inspire, uplift, and change the world.", new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5021), "Fifth Post", new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5021) }
                });

            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("9685b51c-5640-4769-a8ec-7f95b366bbc7"), "MaxPostsPerPage", "10" },
                    { new Guid("c210ec57-3c94-4fb8-8f8c-bf710b345a40"), "SiteName", "My Blog" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "ProfilePictureURL", "Surname" },
                values: new object[,]
                {
                    { new Guid("48703ef3-e1b2-449e-bc3f-244c1ff19c53"), "test2@gmail.com", "user2", "123", "https://picsum.photos/id/807/100/100", "TEST" },
                    { new Guid("7eef1f9e-47b9-4d2f-94fb-a5a025146f83"), "test1@gmail.com", "user1", "123", "https://picsum.photos/id/804/100/100", "TEST" },
                    { new Guid("821ba522-d041-42be-882e-59317f5923e4"), "test5@gmail.com", "user5", "123", "https://picsum.photos/id/832/100/100", "TEST" },
                    { new Guid("90da4d80-ebc8-4f54-919d-35781aa4719d"), "test6@gmail.com", "user6", "123", "https://picsum.photos/id/836/100/100", "TEST" },
                    { new Guid("d08101f3-5acb-4aac-a6df-bd0a9be503ff"), "test3@gmail.com", "user3", "123", "https://picsum.photos/id/823/100/100", "TEST" },
                    { new Guid("ff038a80-ec0a-46f7-acea-d6bcd3cdd9a1"), "test4@gmail.com", "user4", "123", "https://picsum.photos/id/822/100/100", "TEST" }
                });

            migrationBuilder.InsertData(
                table: "CategoryPost",
                columns: new[] { "CategoryId", "PostId", "Id" },
                values: new object[,]
                {
                    { new Guid("22843cd0-8286-451b-a42b-c7dae95e3243"), new Guid("156443ea-bfbe-4ee0-b0b3-01fafae69be2"), new Guid("1c052793-bd27-45df-b003-34272d6e0cdc") },
                    { new Guid("33cdb6c1-df5b-41c9-b15b-d4067f003a1f"), new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e"), new Guid("ee10278d-0aa7-417b-b81c-e1a5af2d2616") },
                    { new Guid("33cdb6c1-df5b-41c9-b15b-d4067f003a1f"), new Guid("f718ef9e-83e7-4413-a6bb-591b2ee9f256"), new Guid("7780ae95-6aae-4989-81be-1ac884566832") },
                    { new Guid("46162259-83ba-464d-9b91-eac6d748e46b"), new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e"), new Guid("bfdd61e2-56ca-44bb-a386-2389d1360a76") },
                    { new Guid("8c287da9-6b3a-4d5b-bfcc-fa3d6a2b1f79"), new Guid("d1c6e166-cc78-4ce7-b7ae-86b4b4cb01cc"), new Guid("8cdc7c85-55eb-4e06-bc22-7eb4d8b24291") },
                    { new Guid("9b4434c7-8da7-4bf6-ab63-5c1a8a18c5de"), new Guid("0a1fefbc-e4c4-488e-a57c-2aa79bdc09fe"), new Guid("6bc6d93f-8ba8-4b50-8414-057ee8c536e8") },
                    { new Guid("c72f01da-b1b0-4ba2-943d-6934bb912a8e"), new Guid("a3cc8e5b-39a1-4818-81c9-ff1cfb12a1df"), new Guid("58dc5757-1eb1-4456-89d9-4bf022227169") }
                });

            migrationBuilder.InsertData(
                table: "PostComment",
                columns: new[] { "Id", "Content", "PostId", "UserId" },
                values: new object[,]
                {
                    { new Guid("29ecee87-6d61-4f96-9126-ca661a55192e"), "Your face brightens up my day – thank you for sharing your joy!", new Guid("a3cc8e5b-39a1-4818-81c9-ff1cfb12a1df"), new Guid("90da4d80-ebc8-4f54-919d-35781aa4719d") },
                    { new Guid("44e24c6b-4670-424d-8f30-db4577ec76d8"), "Your face is a reflection of the sunshine in your heart.", new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e"), new Guid("90da4d80-ebc8-4f54-919d-35781aa4719d") },
                    { new Guid("4fc61f6a-a99c-4278-8786-1250a61126ea"), "Your smile is absolutely radiant, lighting up the entire page!", new Guid("156443ea-bfbe-4ee0-b0b3-01fafae69be2"), new Guid("90da4d80-ebc8-4f54-919d-35781aa4719d") },
                    { new Guid("6865eba8-17ca-4d36-8cb0-1ae220901e30"), "Your expressions are a delightful addition to this blog!", new Guid("f718ef9e-83e7-4413-a6bb-591b2ee9f256"), new Guid("ff038a80-ec0a-46f7-acea-d6bcd3cdd9a1") },
                    { new Guid("714f0953-a0d1-4045-a599-59ef8e458900"), "What a charming face, your positivity is contagious!", new Guid("a3cc8e5b-39a1-4818-81c9-ff1cfb12a1df"), new Guid("7eef1f9e-47b9-4d2f-94fb-a5a025146f83") },
                    { new Guid("7986f84e-1e2b-4caa-9dd5-77eb9a0c6d14"), "Each picture tells a story of happiness and positivity.", new Guid("0a1fefbc-e4c4-488e-a57c-2aa79bdc09fe"), new Guid("7eef1f9e-47b9-4d2f-94fb-a5a025146f83") },
                    { new Guid("7b17645e-22ac-4da6-a58c-d0b857239f36"), "A truly beautiful face that reflects an equally beautiful soul.", new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e"), new Guid("d08101f3-5acb-4aac-a6df-bd0a9be503ff") },
                    { new Guid("af23aa5f-c6d5-444b-9fdf-df986c6e894c"), "Your presence adds a touch of elegance to this blog.", new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e"), new Guid("48703ef3-e1b2-449e-bc3f-244c1ff19c53") },
                    { new Guid("bd09236e-6608-4267-8359-0d90072bcd1d"), "You exude such warmth and kindness in every photo.", new Guid("0a1fefbc-e4c4-488e-a57c-2aa79bdc09fe"), new Guid("48703ef3-e1b2-449e-bc3f-244c1ff19c53") },
                    { new Guid("be03bf8e-f6f3-44fe-bbba-cb426c443e93"), "You've got that perfect combination of grace and charm.", new Guid("d1c6e166-cc78-4ce7-b7ae-86b4b4cb01cc"), new Guid("821ba522-d041-42be-882e-59317f5923e4") }
                });

            migrationBuilder.InsertData(
                table: "PostImage",
                columns: new[] { "Id", "ImageUrl", "PostId" },
                values: new object[,]
                {
                    { new Guid("2455b722-5dba-49bf-add8-6f1c09a6aad0"), "https://picsum.photos/id/10/150/200", new Guid("156443ea-bfbe-4ee0-b0b3-01fafae69be2") },
                    { new Guid("350290aa-5165-4301-999f-983ef01c33fd"), "https://picsum.photos/id/14/150/200", new Guid("f718ef9e-83e7-4413-a6bb-591b2ee9f256") },
                    { new Guid("5a793c1f-b399-45b9-aecf-9e8579279594"), "https://picsum.photos/id/12/150/200", new Guid("0a1fefbc-e4c4-488e-a57c-2aa79bdc09fe") },
                    { new Guid("84e849ad-fc0a-478c-a7c9-3827772ddb6d"), "https://picsum.photos/id/13/150/200", new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e") },
                    { new Guid("a13ed4fc-7a2b-430f-b66a-d60dc8816999"), "https://picsum.photos/id/15/150/200", new Guid("d1c6e166-cc78-4ce7-b7ae-86b4b4cb01cc") },
                    { new Guid("b9d3a013-37fa-4582-aa03-432b9d8f233d"), "https://picsum.photos/id/11/150/200", new Guid("a3cc8e5b-39a1-4818-81c9-ff1cfb12a1df") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_UserId",
                table: "PostComment",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostComment_User_UserId",
                table: "PostComment",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostComment_User_UserId",
                table: "PostComment");

            migrationBuilder.DropIndex(
                name: "IX_PostComment_UserId",
                table: "PostComment");

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("22843cd0-8286-451b-a42b-c7dae95e3243"), new Guid("156443ea-bfbe-4ee0-b0b3-01fafae69be2") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("33cdb6c1-df5b-41c9-b15b-d4067f003a1f"), new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("33cdb6c1-df5b-41c9-b15b-d4067f003a1f"), new Guid("f718ef9e-83e7-4413-a6bb-591b2ee9f256") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("46162259-83ba-464d-9b91-eac6d748e46b"), new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("8c287da9-6b3a-4d5b-bfcc-fa3d6a2b1f79"), new Guid("d1c6e166-cc78-4ce7-b7ae-86b4b4cb01cc") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("9b4434c7-8da7-4bf6-ab63-5c1a8a18c5de"), new Guid("0a1fefbc-e4c4-488e-a57c-2aa79bdc09fe") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("c72f01da-b1b0-4ba2-943d-6934bb912a8e"), new Guid("a3cc8e5b-39a1-4818-81c9-ff1cfb12a1df") });

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: new Guid("ba59d327-153e-4592-b468-1b1561688288"));

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: new Guid("d250ce11-4f06-408b-ae7a-2d185c90429f"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("29ecee87-6d61-4f96-9126-ca661a55192e"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("44e24c6b-4670-424d-8f30-db4577ec76d8"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("4fc61f6a-a99c-4278-8786-1250a61126ea"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("6865eba8-17ca-4d36-8cb0-1ae220901e30"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("714f0953-a0d1-4045-a599-59ef8e458900"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("7986f84e-1e2b-4caa-9dd5-77eb9a0c6d14"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("7b17645e-22ac-4da6-a58c-d0b857239f36"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("af23aa5f-c6d5-444b-9fdf-df986c6e894c"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("bd09236e-6608-4267-8359-0d90072bcd1d"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("be03bf8e-f6f3-44fe-bbba-cb426c443e93"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("2455b722-5dba-49bf-add8-6f1c09a6aad0"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("350290aa-5165-4301-999f-983ef01c33fd"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("5a793c1f-b399-45b9-aecf-9e8579279594"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("84e849ad-fc0a-478c-a7c9-3827772ddb6d"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("a13ed4fc-7a2b-430f-b66a-d60dc8816999"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("b9d3a013-37fa-4582-aa03-432b9d8f233d"));

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: new Guid("9685b51c-5640-4769-a8ec-7f95b366bbc7"));

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: new Guid("c210ec57-3c94-4fb8-8f8c-bf710b345a40"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("22843cd0-8286-451b-a42b-c7dae95e3243"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("33cdb6c1-df5b-41c9-b15b-d4067f003a1f"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("46162259-83ba-464d-9b91-eac6d748e46b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8c287da9-6b3a-4d5b-bfcc-fa3d6a2b1f79"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9b4434c7-8da7-4bf6-ab63-5c1a8a18c5de"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c72f01da-b1b0-4ba2-943d-6934bb912a8e"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("0a1fefbc-e4c4-488e-a57c-2aa79bdc09fe"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("156443ea-bfbe-4ee0-b0b3-01fafae69be2"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("a3cc8e5b-39a1-4818-81c9-ff1cfb12a1df"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("d1c6e166-cc78-4ce7-b7ae-86b4b4cb01cc"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("f718ef9e-83e7-4413-a6bb-591b2ee9f256"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("48703ef3-e1b2-449e-bc3f-244c1ff19c53"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7eef1f9e-47b9-4d2f-94fb-a5a025146f83"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("821ba522-d041-42be-882e-59317f5923e4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("90da4d80-ebc8-4f54-919d-35781aa4719d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d08101f3-5acb-4aac-a6df-bd0a9be503ff"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ff038a80-ec0a-46f7-acea-d6bcd3cdd9a1"));

            migrationBuilder.DropColumn(
                name: "ProfilePictureURL",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PostComment");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Page",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1500)",
                oldMaxLength: 1500);

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
    }
}
