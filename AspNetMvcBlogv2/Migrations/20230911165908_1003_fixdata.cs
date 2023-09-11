using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetMvcBlogv2.Migrations
{
    /// <inheritdoc />
    public partial class _1003_fixdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("114f001e-95a9-4445-a713-adbe9f3f1ce0"), "Health and Fitness" },
                    { new Guid("2668e13c-1e00-4f44-b823-62a84f9b3253"), "Relationships" },
                    { new Guid("43c99510-0f32-4fc4-9c34-662a4dfcf8b3"), "Sustainability" },
                    { new Guid("915a31b4-64a8-4664-92fe-a912aea4f4b4"), "Travel and Exploration" },
                    { new Guid("9d8ddd44-cef9-428a-ba43-91676fbb2308"), "Personal Growth" },
                    { new Guid("a7b210ad-9096-4c7d-ba37-4e9cc2469ba5"), "Creativity" }
                });

            migrationBuilder.InsertData(
                table: "Page",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { new Guid("2b8cffd1-f71c-44e2-939c-b7fd1f7d1102"), "Whether you have a question, feedback, or a partnership inquiry, our \"Contact\" page is the gateway to reach out to us. We're eager to hear your thoughts, answer your queries, and collaborate with like-minded individuals and organizations who share our passions.\r\n\r\nWe've designed our contact form to be user-friendly, ensuring that your message reaches us without any hassle. Your input is not just welcomed; it's highly appreciated, as it helps us improve and tailor our content to better serve your needs and interests.", "Contact" },
                    { new Guid("6e936f9d-8993-42db-87bf-dcd937815cf5"), "The \"About Us\" page on our blogsite is a window into the heart and soul of our digital presence. It's the place where we introduce ourselves, sharing the story behind our passion and purpose. We're not just another website; we're a team of dedicated individuals with a common mission.", "About Us" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Content", "PublishedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("496d9dfc-b54c-4b8a-b25c-771e71f2b8cf"), "Creativity knows no bounds, and it resides within each of us. Whether you express it through art, writing, music, or any other form, don't hesitate to let your imagination run wild. Your unique creative voice has the power to inspire, uplift, and change the world.", new DateTime(2023, 9, 11, 19, 59, 8, 587, DateTimeKind.Local).AddTicks(8054), "Fifth Post", new DateTime(2023, 9, 11, 19, 59, 8, 587, DateTimeKind.Local).AddTicks(8054) },
                    { new Guid("8e55e02d-70e1-4fa3-b6a2-10d45137eb84"), "Maintaining a healthy lifestyle goes beyond hitting the gym; it's about making mindful choices every day. Whether it's choosing nutritious foods or finding joy in outdoor activities, taking small steps can lead to significant improvements in your overall well-being. Remember, your journey to better health is a marathon, not a sprint.", new DateTime(2023, 9, 11, 19, 59, 8, 587, DateTimeKind.Local).AddTicks(8046), "First Post", new DateTime(2023, 9, 11, 19, 59, 8, 587, DateTimeKind.Local).AddTicks(8046) },
                    { new Guid("9d786321-c128-456e-918e-3a583ae6c3cd"), "Exploring new places broadens your horizons and enriches your life in ways you can't imagine. From the bustling streets of vibrant cities to the serene beauty of remote landscapes, every destination has a story to tell. So, pack your bags, embrace the adventure, and let the world be your teacher.", new DateTime(2023, 9, 11, 19, 59, 8, 587, DateTimeKind.Local).AddTicks(8048), "Second Post", new DateTime(2023, 9, 11, 19, 59, 8, 587, DateTimeKind.Local).AddTicks(8049) },
                    { new Guid("ee79e0cc-8b5d-432e-9263-e5f8933be874"), "Personal growth is a lifelong journey of self-discovery and self-improvement. It's about embracing change, learning from experiences, and continuously evolving into the best version of yourself. Remember, progress may be slow at times, but every step forward is a step closer to your goals.", new DateTime(2023, 9, 11, 19, 59, 8, 587, DateTimeKind.Local).AddTicks(8050), "Third Post", new DateTime(2023, 9, 11, 19, 59, 8, 587, DateTimeKind.Local).AddTicks(8050) },
                    { new Guid("f47f778d-2f98-492a-8a88-bc7c969b90b9"), "The planet we call home needs our care and attention now more than ever. Embracing sustainable practices in our daily lives, from reducing waste to conserving energy, is not just a choice but a responsibility. Together, we can create a greener and healthier future for generations to come.", new DateTime(2023, 9, 11, 19, 59, 8, 587, DateTimeKind.Local).AddTicks(8055), "Sixst Post", new DateTime(2023, 9, 11, 19, 59, 8, 587, DateTimeKind.Local).AddTicks(8056) },
                    { new Guid("fb99541f-21b9-4923-b6e0-9ccc6f3437f2"), "Strong and meaningful relationships are the cornerstone of a fulfilling life. Cultivate connections that are built on trust, communication, and mutual respect. These bonds will provide unwavering support and joy through life's ups and downs.", new DateTime(2023, 9, 11, 19, 59, 8, 587, DateTimeKind.Local).AddTicks(8052), "Forth Post", new DateTime(2023, 9, 11, 19, 59, 8, 587, DateTimeKind.Local).AddTicks(8052) }
                });

            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("144ac95e-1eb7-40b7-8274-b5bb75bf83a8"), "MaxPostsPerPage", "10" },
                    { new Guid("c1f565d1-b67a-4843-9bde-acd9ab1a954a"), "SiteName", "My Blog" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "ProfilePictureURL", "Surname" },
                values: new object[,]
                {
                    { new Guid("5bf213f8-a466-4501-8e22-c37d79d5d7c4"), "test5@gmail.com", "user5", "123", "https://picsum.photos/id/832/100/100", "TEST" },
                    { new Guid("7bb39990-e98b-4ed5-881b-4c707afc6479"), "test1@gmail.com", "user1", "123", "https://picsum.photos/id/804/100/100", "TEST" },
                    { new Guid("906d9194-425f-47ea-b3cd-16ecd9dc033d"), "test3@gmail.com", "user3", "123", "https://picsum.photos/id/823/100/100", "TEST" },
                    { new Guid("9d5b29c7-d44a-48d2-8816-de9bd943f533"), "test6@gmail.com", "user6", "123", "https://picsum.photos/id/836/100/100", "TEST" },
                    { new Guid("c02b5bfb-247d-46fb-b5d8-722fcf1038c4"), "test4@gmail.com", "user4", "123", "https://picsum.photos/id/822/100/100", "TEST" },
                    { new Guid("f94f3678-45b3-4b18-9879-5b082db5c836"), "test2@gmail.com", "user2", "123", "https://picsum.photos/id/807/100/100", "TEST" }
                });

            migrationBuilder.InsertData(
                table: "CategoryPost",
                columns: new[] { "CategoryId", "PostId", "Id" },
                values: new object[,]
                {
                    { new Guid("114f001e-95a9-4445-a713-adbe9f3f1ce0"), new Guid("8e55e02d-70e1-4fa3-b6a2-10d45137eb84"), new Guid("6193961b-aa14-40b7-8638-bd67baaeb5cf") },
                    { new Guid("2668e13c-1e00-4f44-b823-62a84f9b3253"), new Guid("fb99541f-21b9-4923-b6e0-9ccc6f3437f2"), new Guid("4fcfd031-d8e0-435d-b3c1-7cbe8404c733") },
                    { new Guid("43c99510-0f32-4fc4-9c34-662a4dfcf8b3"), new Guid("f47f778d-2f98-492a-8a88-bc7c969b90b9"), new Guid("b67252c7-0d37-49c0-b616-b60e15fda565") },
                    { new Guid("915a31b4-64a8-4664-92fe-a912aea4f4b4"), new Guid("9d786321-c128-456e-918e-3a583ae6c3cd"), new Guid("287e5d0e-a0f9-48fc-963a-54ff597ea936") },
                    { new Guid("9d8ddd44-cef9-428a-ba43-91676fbb2308"), new Guid("ee79e0cc-8b5d-432e-9263-e5f8933be874"), new Guid("7c427c91-b5b8-46b1-adaa-2079a1583612") },
                    { new Guid("a7b210ad-9096-4c7d-ba37-4e9cc2469ba5"), new Guid("496d9dfc-b54c-4b8a-b25c-771e71f2b8cf"), new Guid("d292ec21-3b06-4d0d-a42d-7f3c9b2c1854") },
                    { new Guid("a7b210ad-9096-4c7d-ba37-4e9cc2469ba5"), new Guid("fb99541f-21b9-4923-b6e0-9ccc6f3437f2"), new Guid("cd1efab3-f7c4-468e-a9c1-cd35920f7a45") }
                });

            migrationBuilder.InsertData(
                table: "PostComment",
                columns: new[] { "Id", "Content", "PostId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1756a438-24f5-4aca-bc9f-c9936f2e8f26"), "What a charming face, your positivity is contagious!", new Guid("9d786321-c128-456e-918e-3a583ae6c3cd"), new Guid("7bb39990-e98b-4ed5-881b-4c707afc6479") },
                    { new Guid("1a66a4e4-f9a6-4fe6-b3b6-e090e5ad289d"), "You've got that perfect combination of grace and charm.", new Guid("f47f778d-2f98-492a-8a88-bc7c969b90b9"), new Guid("5bf213f8-a466-4501-8e22-c37d79d5d7c4") },
                    { new Guid("388153c9-1f2d-431d-9427-57619d4d09e2"), "Your smile is absolutely radiant, lighting up the entire page!", new Guid("8e55e02d-70e1-4fa3-b6a2-10d45137eb84"), new Guid("9d5b29c7-d44a-48d2-8816-de9bd943f533") },
                    { new Guid("64d0546a-628a-4fd4-9b5f-32b105d929f2"), "Your face brightens up my day – thank you for sharing your joy!", new Guid("9d786321-c128-456e-918e-3a583ae6c3cd"), new Guid("9d5b29c7-d44a-48d2-8816-de9bd943f533") },
                    { new Guid("78c8d21b-6bf9-4540-92c7-5e2b1a7200f7"), "Your presence adds a touch of elegance to this blog.", new Guid("fb99541f-21b9-4923-b6e0-9ccc6f3437f2"), new Guid("f94f3678-45b3-4b18-9879-5b082db5c836") },
                    { new Guid("835e3841-9027-42c2-b3d9-439aededc8fc"), "Each picture tells a story of happiness and positivity.", new Guid("ee79e0cc-8b5d-432e-9263-e5f8933be874"), new Guid("7bb39990-e98b-4ed5-881b-4c707afc6479") },
                    { new Guid("b0154e00-9735-404e-9998-3fc6ba679375"), "You exude such warmth and kindness in every photo.", new Guid("ee79e0cc-8b5d-432e-9263-e5f8933be874"), new Guid("f94f3678-45b3-4b18-9879-5b082db5c836") },
                    { new Guid("b9053175-85c6-44f8-ad92-de123d247afd"), "Your face is a reflection of the sunshine in your heart.", new Guid("fb99541f-21b9-4923-b6e0-9ccc6f3437f2"), new Guid("9d5b29c7-d44a-48d2-8816-de9bd943f533") },
                    { new Guid("d516588b-6368-42ef-b58d-5fc3f7322901"), "A truly beautiful face that reflects an equally beautiful soul.", new Guid("fb99541f-21b9-4923-b6e0-9ccc6f3437f2"), new Guid("906d9194-425f-47ea-b3cd-16ecd9dc033d") },
                    { new Guid("f2ddcec6-11a1-4187-ab19-308980ae2aae"), "Your expressions are a delightful addition to this blog!", new Guid("496d9dfc-b54c-4b8a-b25c-771e71f2b8cf"), new Guid("c02b5bfb-247d-46fb-b5d8-722fcf1038c4") }
                });

            migrationBuilder.InsertData(
                table: "PostImage",
                columns: new[] { "Id", "ImageUrl", "PostId" },
                values: new object[,]
                {
                    { new Guid("5c7d3451-3591-4d82-a04b-5ff0b6cb5107"), "https://picsum.photos/id/10/350/350", new Guid("8e55e02d-70e1-4fa3-b6a2-10d45137eb84") },
                    { new Guid("6dbc5ee9-c910-4032-8d38-4d4545efaaf2"), "https://picsum.photos/id/15/350/350", new Guid("f47f778d-2f98-492a-8a88-bc7c969b90b9") },
                    { new Guid("7f3e52fe-8595-4ad0-b3b4-11e8e7e2d8f9"), "https://picsum.photos/id/14/350/350", new Guid("496d9dfc-b54c-4b8a-b25c-771e71f2b8cf") },
                    { new Guid("815199da-1fc5-4be3-af9e-836d78a1f1c7"), "https://picsum.photos/id/12/350/350", new Guid("ee79e0cc-8b5d-432e-9263-e5f8933be874") },
                    { new Guid("a05d6c26-8bc4-4837-9fe3-a14ca95052c6"), "https://picsum.photos/id/11/350/350", new Guid("9d786321-c128-456e-918e-3a583ae6c3cd") },
                    { new Guid("e14cce1b-3480-42fe-8214-64f411b92ef5"), "https://picsum.photos/id/13/350/350", new Guid("fb99541f-21b9-4923-b6e0-9ccc6f3437f2") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("114f001e-95a9-4445-a713-adbe9f3f1ce0"), new Guid("8e55e02d-70e1-4fa3-b6a2-10d45137eb84") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("2668e13c-1e00-4f44-b823-62a84f9b3253"), new Guid("fb99541f-21b9-4923-b6e0-9ccc6f3437f2") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("43c99510-0f32-4fc4-9c34-662a4dfcf8b3"), new Guid("f47f778d-2f98-492a-8a88-bc7c969b90b9") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("915a31b4-64a8-4664-92fe-a912aea4f4b4"), new Guid("9d786321-c128-456e-918e-3a583ae6c3cd") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("9d8ddd44-cef9-428a-ba43-91676fbb2308"), new Guid("ee79e0cc-8b5d-432e-9263-e5f8933be874") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("a7b210ad-9096-4c7d-ba37-4e9cc2469ba5"), new Guid("496d9dfc-b54c-4b8a-b25c-771e71f2b8cf") });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { new Guid("a7b210ad-9096-4c7d-ba37-4e9cc2469ba5"), new Guid("fb99541f-21b9-4923-b6e0-9ccc6f3437f2") });

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: new Guid("2b8cffd1-f71c-44e2-939c-b7fd1f7d1102"));

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: new Guid("6e936f9d-8993-42db-87bf-dcd937815cf5"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("1756a438-24f5-4aca-bc9f-c9936f2e8f26"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("1a66a4e4-f9a6-4fe6-b3b6-e090e5ad289d"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("388153c9-1f2d-431d-9427-57619d4d09e2"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("64d0546a-628a-4fd4-9b5f-32b105d929f2"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("78c8d21b-6bf9-4540-92c7-5e2b1a7200f7"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("835e3841-9027-42c2-b3d9-439aededc8fc"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("b0154e00-9735-404e-9998-3fc6ba679375"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("b9053175-85c6-44f8-ad92-de123d247afd"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("d516588b-6368-42ef-b58d-5fc3f7322901"));

            migrationBuilder.DeleteData(
                table: "PostComment",
                keyColumn: "Id",
                keyValue: new Guid("f2ddcec6-11a1-4187-ab19-308980ae2aae"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("5c7d3451-3591-4d82-a04b-5ff0b6cb5107"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("6dbc5ee9-c910-4032-8d38-4d4545efaaf2"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("7f3e52fe-8595-4ad0-b3b4-11e8e7e2d8f9"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("815199da-1fc5-4be3-af9e-836d78a1f1c7"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("a05d6c26-8bc4-4837-9fe3-a14ca95052c6"));

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: new Guid("e14cce1b-3480-42fe-8214-64f411b92ef5"));

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: new Guid("144ac95e-1eb7-40b7-8274-b5bb75bf83a8"));

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: new Guid("c1f565d1-b67a-4843-9bde-acd9ab1a954a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("114f001e-95a9-4445-a713-adbe9f3f1ce0"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2668e13c-1e00-4f44-b823-62a84f9b3253"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("43c99510-0f32-4fc4-9c34-662a4dfcf8b3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("915a31b4-64a8-4664-92fe-a912aea4f4b4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9d8ddd44-cef9-428a-ba43-91676fbb2308"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a7b210ad-9096-4c7d-ba37-4e9cc2469ba5"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("496d9dfc-b54c-4b8a-b25c-771e71f2b8cf"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("8e55e02d-70e1-4fa3-b6a2-10d45137eb84"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("9d786321-c128-456e-918e-3a583ae6c3cd"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("ee79e0cc-8b5d-432e-9263-e5f8933be874"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("f47f778d-2f98-492a-8a88-bc7c969b90b9"));

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: new Guid("fb99541f-21b9-4923-b6e0-9ccc6f3437f2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5bf213f8-a466-4501-8e22-c37d79d5d7c4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7bb39990-e98b-4ed5-881b-4c707afc6479"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("906d9194-425f-47ea-b3cd-16ecd9dc033d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9d5b29c7-d44a-48d2-8816-de9bd943f533"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c02b5bfb-247d-46fb-b5d8-722fcf1038c4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f94f3678-45b3-4b18-9879-5b082db5c836"));

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
    }
}
