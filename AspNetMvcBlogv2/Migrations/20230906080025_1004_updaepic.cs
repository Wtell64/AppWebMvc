using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetMvcBlogv2.Migrations
{
    /// <inheritdoc />
    public partial class _1004_updaepic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8c1ff986-b6f7-4e10-b1db-12404a7a3dd8"), "Sustainability" },
                    { new Guid("ac0804c8-2312-47ef-ba30-a76464d55a7b"), "Creativity" },
                    { new Guid("af8ad34d-fbbd-4b1f-b200-494c1f5f6a33"), "Relationships" },
                    { new Guid("c0e13f1d-f7a1-48d7-a45d-ff2b9f1434e9"), "Health and Fitness" },
                    { new Guid("f590c268-d8ac-400c-b7b3-e07b55b44af4"), "Personal Growth" },
                    { new Guid("f911823c-49e0-4df2-b4bf-2e62ec0e26ed"), "Travel and Exploration" }
                });

            migrationBuilder.InsertData(
                table: "Page",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { new Guid("52841646-adf3-44e3-9449-1f5b76b571b7"), "The \"About Us\" page on our blogsite is a window into the heart and soul of our digital presence. It's the place where we introduce ourselves, sharing the story behind our passion and purpose. We're not just another website; we're a team of dedicated individuals with a common mission.", "About Us" },
                    { new Guid("83d4a99a-61a7-4d4d-a31b-07b826dbe90e"), "Whether you have a question, feedback, or a partnership inquiry, our \"Contact\" page is the gateway to reach out to us. We're eager to hear your thoughts, answer your queries, and collaborate with like-minded individuals and organizations who share our passions.\r\n\r\nWe've designed our contact form to be user-friendly, ensuring that your message reaches us without any hassle. Your input is not just welcomed; it's highly appreciated, as it helps us improve and tailor our content to better serve your needs and interests.", "Contact" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Content", "PublishedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("15213c03-52be-4a67-9c04-51ffd7fdf999"), "The planet we call home needs our care and attention now more than ever. Embracing sustainable practices in our daily lives, from reducing waste to conserving energy, is not just a choice but a responsibility. Together, we can create a greener and healthier future for generations to come.", new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2836), "Sixst Post", new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2836) },
                    { new Guid("18aab0b6-8118-488e-bdd9-b938e431b5ca"), "Personal growth is a lifelong journey of self-discovery and self-improvement. It's about embracing change, learning from experiences, and continuously evolving into the best version of yourself. Remember, progress may be slow at times, but every step forward is a step closer to your goals.", new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2830), "Third Post", new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2831) },
                    { new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72"), "Strong and meaningful relationships are the cornerstone of a fulfilling life. Cultivate connections that are built on trust, communication, and mutual respect. These bonds will provide unwavering support and joy through life's ups and downs.", new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2832), "Forth Post", new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2833) },
                    { new Guid("439dade8-50bd-4427-9de1-2f6a176f73f0"), "Maintaining a healthy lifestyle goes beyond hitting the gym; it's about making mindful choices every day. Whether it's choosing nutritious foods or finding joy in outdoor activities, taking small steps can lead to significant improvements in your overall well-being. Remember, your journey to better health is a marathon, not a sprint.", new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2826), "First Post", new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2827) },
                    { new Guid("5d777917-f423-4aff-92ce-81c63a6afe10"), "Creativity knows no bounds, and it resides within each of us. Whether you express it through art, writing, music, or any other form, don't hesitate to let your imagination run wild. Your unique creative voice has the power to inspire, uplift, and change the world.", new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2834), "Fifth Post", new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2834) },
                    { new Guid("66c431f1-ae82-41ff-9a11-cbaa74877261"), "Exploring new places broadens your horizons and enriches your life in ways you can't imagine. From the bustling streets of vibrant cities to the serene beauty of remote landscapes, every destination has a story to tell. So, pack your bags, embrace the adventure, and let the world be your teacher.", new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2829), "Second Post", new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2829) }
                });

            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("ce56d7d0-271d-4aaa-b03d-8a2eab27b2ef"), "SiteName", "My Blog" },
                    { new Guid("e34e8be3-13e0-440f-b6cb-492122b62be9"), "MaxPostsPerPage", "10" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "ProfilePictureURL", "Surname" },
                values: new object[,]
                {
                    { new Guid("2db3d20f-217d-4bb8-a1f2-4177013da392"), "test3@gmail.com", "user3", "123", "https://picsum.photos/id/823/100/100", "TEST" },
                    { new Guid("4d8b7056-9bc9-4c37-94bd-cbd07562fcbd"), "test1@gmail.com", "user1", "123", "https://picsum.photos/id/804/100/100", "TEST" },
                    { new Guid("72debf82-a0b0-473b-aed5-ec2d98230db3"), "test4@gmail.com", "user4", "123", "https://picsum.photos/id/822/100/100", "TEST" },
                    { new Guid("91cf8f33-e1d7-4c4b-af0c-a20c2f518233"), "test6@gmail.com", "user6", "123", "https://picsum.photos/id/836/100/100", "TEST" },
                    { new Guid("a4caba2f-a493-4e41-8148-aeb4ebb89263"), "test5@gmail.com", "user5", "123", "https://picsum.photos/id/832/100/100", "TEST" },
                    { new Guid("d75116bc-d76b-4eba-8e8a-26ff4cccfbc0"), "test2@gmail.com", "user2", "123", "https://picsum.photos/id/807/100/100", "TEST" }
                });

            migrationBuilder.InsertData(
                table: "CategoryPost",
                columns: new[] { "CategoryId", "PostId", "Id" },
                values: new object[,]
                {
                    { new Guid("8c1ff986-b6f7-4e10-b1db-12404a7a3dd8"), new Guid("15213c03-52be-4a67-9c04-51ffd7fdf999"), new Guid("ba272e96-1b54-42ee-9f35-e1a98010018d") },
                    { new Guid("ac0804c8-2312-47ef-ba30-a76464d55a7b"), new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72"), new Guid("29b0a4bc-95f7-47ef-864c-d86b261795df") },
                    { new Guid("ac0804c8-2312-47ef-ba30-a76464d55a7b"), new Guid("5d777917-f423-4aff-92ce-81c63a6afe10"), new Guid("33bf0c09-7335-472c-adc7-470757066524") },
                    { new Guid("af8ad34d-fbbd-4b1f-b200-494c1f5f6a33"), new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72"), new Guid("37acf730-2ed0-4962-af90-b024e5f1cece") },
                    { new Guid("c0e13f1d-f7a1-48d7-a45d-ff2b9f1434e9"), new Guid("439dade8-50bd-4427-9de1-2f6a176f73f0"), new Guid("63e1dee7-0fc8-4cd6-aecb-844aacf99a35") },
                    { new Guid("f590c268-d8ac-400c-b7b3-e07b55b44af4"), new Guid("18aab0b6-8118-488e-bdd9-b938e431b5ca"), new Guid("5d96b7f2-21dd-4df8-9275-2263ffab6457") },
                    { new Guid("f911823c-49e0-4df2-b4bf-2e62ec0e26ed"), new Guid("66c431f1-ae82-41ff-9a11-cbaa74877261"), new Guid("90136f6e-aa53-4134-ab69-dc203476d2b8") }
                });

            migrationBuilder.InsertData(
                table: "PostComment",
                columns: new[] { "Id", "Content", "PostId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1badb9f3-c015-4dad-b35e-78bc98ad56c4"), "Your presence adds a touch of elegance to this blog.", new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72"), new Guid("d75116bc-d76b-4eba-8e8a-26ff4cccfbc0") },
                    { new Guid("3bd34f63-dcdc-42df-a479-5a0cffb8cd14"), "Your face is a reflection of the sunshine in your heart.", new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72"), new Guid("91cf8f33-e1d7-4c4b-af0c-a20c2f518233") },
                    { new Guid("4ff0ca7f-7ae7-4347-be84-af3cec52c217"), "Each picture tells a story of happiness and positivity.", new Guid("18aab0b6-8118-488e-bdd9-b938e431b5ca"), new Guid("4d8b7056-9bc9-4c37-94bd-cbd07562fcbd") },
                    { new Guid("89b06d82-fde3-47cd-ae8b-8a52dae991b1"), "You exude such warmth and kindness in every photo.", new Guid("18aab0b6-8118-488e-bdd9-b938e431b5ca"), new Guid("d75116bc-d76b-4eba-8e8a-26ff4cccfbc0") },
                    { new Guid("8adcc08b-bc6b-4413-9bf9-f2a6d27a5925"), "Your smile is absolutely radiant, lighting up the entire page!", new Guid("439dade8-50bd-4427-9de1-2f6a176f73f0"), new Guid("91cf8f33-e1d7-4c4b-af0c-a20c2f518233") },
                    { new Guid("95b8bd12-be8d-483d-aba8-7e5410e76d57"), "Your face brightens up my day – thank you for sharing your joy!", new Guid("66c431f1-ae82-41ff-9a11-cbaa74877261"), new Guid("91cf8f33-e1d7-4c4b-af0c-a20c2f518233") },
                    { new Guid("aa6525ad-3f3a-4dd3-8aad-36c54c292ad1"), "You've got that perfect combination of grace and charm.", new Guid("15213c03-52be-4a67-9c04-51ffd7fdf999"), new Guid("a4caba2f-a493-4e41-8148-aeb4ebb89263") },
                    { new Guid("e14c4d04-134d-4148-a996-7490c5378cf2"), "Your expressions are a delightful addition to this blog!", new Guid("5d777917-f423-4aff-92ce-81c63a6afe10"), new Guid("72debf82-a0b0-473b-aed5-ec2d98230db3") },
                    { new Guid("e5f08c23-fe0d-455a-925a-09a14287ac4d"), "A truly beautiful face that reflects an equally beautiful soul.", new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72"), new Guid("2db3d20f-217d-4bb8-a1f2-4177013da392") },
                    { new Guid("ff664ad2-fdc9-4fb4-8dc2-6b628517b9c0"), "What a charming face, your positivity is contagious!", new Guid("66c431f1-ae82-41ff-9a11-cbaa74877261"), new Guid("4d8b7056-9bc9-4c37-94bd-cbd07562fcbd") }
                });

            migrationBuilder.InsertData(
                table: "PostImage",
                columns: new[] { "Id", "ImageUrl", "PostId" },
                values: new object[,]
                {
                    { new Guid("39987fa1-95d8-4af3-ac66-b7366e509ec0"), "https://picsum.photos/id/14/350/350", new Guid("5d777917-f423-4aff-92ce-81c63a6afe10") },
                    { new Guid("b01f978c-ba1c-47b0-9400-094ee299c4ed"), "https://picsum.photos/id/10/350/350", new Guid("439dade8-50bd-4427-9de1-2f6a176f73f0") },
                    { new Guid("cffae535-5db1-4d1f-a2b3-99bca61420c8"), "https://picsum.photos/id/15/350/350", new Guid("15213c03-52be-4a67-9c04-51ffd7fdf999") },
                    { new Guid("e24a7141-7ba7-48de-8950-fb46594f2b2c"), "https://picsum.photos/id/13/350/350", new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72") },
                    { new Guid("eb9096dd-620c-4775-9c50-281369a6acb0"), "https://picsum.photos/id/12/350/350", new Guid("18aab0b6-8118-488e-bdd9-b938e431b5ca") },
                    { new Guid("ebe6cf98-ca2a-4fde-a890-9d6c2a5d89e4"), "https://picsum.photos/id/11/350/350", new Guid("66c431f1-ae82-41ff-9a11-cbaa74877261") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("8c1ff986-b6f7-4e10-b1db-12404a7a3dd8"), new Guid("15213c03-52be-4a67-9c04-51ffd7fdf999") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("ac0804c8-2312-47ef-ba30-a76464d55a7b"), new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("ac0804c8-2312-47ef-ba30-a76464d55a7b"), new Guid("5d777917-f423-4aff-92ce-81c63a6afe10") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("af8ad34d-fbbd-4b1f-b200-494c1f5f6a33"), new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("c0e13f1d-f7a1-48d7-a45d-ff2b9f1434e9"), new Guid("439dade8-50bd-4427-9de1-2f6a176f73f0") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("f590c268-d8ac-400c-b7b3-e07b55b44af4"), new Guid("18aab0b6-8118-488e-bdd9-b938e431b5ca") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("f911823c-49e0-4df2-b4bf-2e62ec0e26ed"), new Guid("66c431f1-ae82-41ff-9a11-cbaa74877261") });

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: new Guid("52841646-adf3-44e3-9449-1f5b76b571b7"));

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: new Guid("83d4a99a-61a7-4d4d-a31b-07b826dbe90e"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("1badb9f3-c015-4dad-b35e-78bc98ad56c4"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("3bd34f63-dcdc-42df-a479-5a0cffb8cd14"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("4ff0ca7f-7ae7-4347-be84-af3cec52c217"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("89b06d82-fde3-47cd-ae8b-8a52dae991b1"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("8adcc08b-bc6b-4413-9bf9-f2a6d27a5925"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("95b8bd12-be8d-483d-aba8-7e5410e76d57"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("aa6525ad-3f3a-4dd3-8aad-36c54c292ad1"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("e14c4d04-134d-4148-a996-7490c5378cf2"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("e5f08c23-fe0d-455a-925a-09a14287ac4d"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("ff664ad2-fdc9-4fb4-8dc2-6b628517b9c0"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("39987fa1-95d8-4af3-ac66-b7366e509ec0"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("b01f978c-ba1c-47b0-9400-094ee299c4ed"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("cffae535-5db1-4d1f-a2b3-99bca61420c8"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("e24a7141-7ba7-48de-8950-fb46594f2b2c"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("eb9096dd-620c-4775-9c50-281369a6acb0"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("ebe6cf98-ca2a-4fde-a890-9d6c2a5d89e4"));

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: new Guid("ce56d7d0-271d-4aaa-b03d-8a2eab27b2ef"));

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: new Guid("e34e8be3-13e0-440f-b6cb-492122b62be9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8c1ff986-b6f7-4e10-b1db-12404a7a3dd8"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ac0804c8-2312-47ef-ba30-a76464d55a7b"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("af8ad34d-fbbd-4b1f-b200-494c1f5f6a33"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c0e13f1d-f7a1-48d7-a45d-ff2b9f1434e9"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f590c268-d8ac-400c-b7b3-e07b55b44af4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("f911823c-49e0-4df2-b4bf-2e62ec0e26ed"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("15213c03-52be-4a67-9c04-51ffd7fdf999"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("18aab0b6-8118-488e-bdd9-b938e431b5ca"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("439dade8-50bd-4427-9de1-2f6a176f73f0"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("5d777917-f423-4aff-92ce-81c63a6afe10"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("66c431f1-ae82-41ff-9a11-cbaa74877261"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2db3d20f-217d-4bb8-a1f2-4177013da392"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4d8b7056-9bc9-4c37-94bd-cbd07562fcbd"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("72debf82-a0b0-473b-aed5-ec2d98230db3"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("91cf8f33-e1d7-4c4b-af0c-a20c2f518233"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a4caba2f-a493-4e41-8148-aeb4ebb89263"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d75116bc-d76b-4eba-8e8a-26ff4cccfbc0"));

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
        }
    }
}
