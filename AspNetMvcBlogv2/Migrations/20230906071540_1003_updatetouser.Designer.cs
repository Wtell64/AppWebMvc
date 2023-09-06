﻿// <auto-generated />
using System;
using AspNetMvcBlogv2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetMvcBlogv2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230906071540_1003_updatetouser")]
    partial class _1003_updatetouser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspNetMvcBlogv2.Data.Entity.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = new Guid("22843cd0-8286-451b-a42b-c7dae95e3243"),
                            Name = "Health and Fitness"
                        },
                        new
                        {
                            Id = new Guid("c72f01da-b1b0-4ba2-943d-6934bb912a8e"),
                            Name = "Travel and Exploration"
                        },
                        new
                        {
                            Id = new Guid("9b4434c7-8da7-4bf6-ab63-5c1a8a18c5de"),
                            Name = "Personal Growth"
                        },
                        new
                        {
                            Id = new Guid("46162259-83ba-464d-9b91-eac6d748e46b"),
                            Name = "Relationships"
                        },
                        new
                        {
                            Id = new Guid("33cdb6c1-df5b-41c9-b15b-d4067f003a1f"),
                            Name = "Creativity"
                        },
                        new
                        {
                            Id = new Guid("8c287da9-6b3a-4d5b-bfcc-fa3d6a2b1f79"),
                            Name = "Sustainability"
                        });
                });

            modelBuilder.Entity("AspNetMvcBlogv2.Data.Entity.CategoryPost", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoryId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("CategoryPost");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("22843cd0-8286-451b-a42b-c7dae95e3243"),
                            PostId = new Guid("156443ea-bfbe-4ee0-b0b3-01fafae69be2"),
                            Id = new Guid("1c052793-bd27-45df-b003-34272d6e0cdc")
                        },
                        new
                        {
                            CategoryId = new Guid("c72f01da-b1b0-4ba2-943d-6934bb912a8e"),
                            PostId = new Guid("a3cc8e5b-39a1-4818-81c9-ff1cfb12a1df"),
                            Id = new Guid("58dc5757-1eb1-4456-89d9-4bf022227169")
                        },
                        new
                        {
                            CategoryId = new Guid("9b4434c7-8da7-4bf6-ab63-5c1a8a18c5de"),
                            PostId = new Guid("0a1fefbc-e4c4-488e-a57c-2aa79bdc09fe"),
                            Id = new Guid("6bc6d93f-8ba8-4b50-8414-057ee8c536e8")
                        },
                        new
                        {
                            CategoryId = new Guid("33cdb6c1-df5b-41c9-b15b-d4067f003a1f"),
                            PostId = new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e"),
                            Id = new Guid("ee10278d-0aa7-417b-b81c-e1a5af2d2616")
                        },
                        new
                        {
                            CategoryId = new Guid("46162259-83ba-464d-9b91-eac6d748e46b"),
                            PostId = new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e"),
                            Id = new Guid("bfdd61e2-56ca-44bb-a386-2389d1360a76")
                        },
                        new
                        {
                            CategoryId = new Guid("33cdb6c1-df5b-41c9-b15b-d4067f003a1f"),
                            PostId = new Guid("f718ef9e-83e7-4413-a6bb-591b2ee9f256"),
                            Id = new Guid("7780ae95-6aae-4989-81be-1ac884566832")
                        },
                        new
                        {
                            CategoryId = new Guid("8c287da9-6b3a-4d5b-bfcc-fa3d6a2b1f79"),
                            PostId = new Guid("d1c6e166-cc78-4ce7-b7ae-86b4b4cb01cc"),
                            Id = new Guid("8cdc7c85-55eb-4e06-bc22-7eb4d8b24291")
                        });
                });

            modelBuilder.Entity("AspNetMvcBlogv2.Data.Entity.Page", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Page");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d250ce11-4f06-408b-ae7a-2d185c90429f"),
                            Content = "The \"About Us\" page on our blogsite is a window into the heart and soul of our digital presence. It's the place where we introduce ourselves, sharing the story behind our passion and purpose. We're not just another website; we're a team of dedicated individuals with a common mission.",
                            Title = "About Us"
                        },
                        new
                        {
                            Id = new Guid("ba59d327-153e-4592-b468-1b1561688288"),
                            Content = "Whether you have a question, feedback, or a partnership inquiry, our \"Contact\" page is the gateway to reach out to us. We're eager to hear your thoughts, answer your queries, and collaborate with like-minded individuals and organizations who share our passions.\r\n\r\nWe've designed our contact form to be user-friendly, ensuring that your message reaches us without any hassle. Your input is not just welcomed; it's highly appreciated, as it helps us improve and tailor our content to better serve your needs and interests.",
                            Title = "Contact"
                        });
                });

            modelBuilder.Entity("AspNetMvcBlogv2.Data.Entity.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("PublishedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Post");

                    b.HasData(
                        new
                        {
                            Id = new Guid("156443ea-bfbe-4ee0-b0b3-01fafae69be2"),
                            Content = "Maintaining a healthy lifestyle goes beyond hitting the gym; it's about making mindful choices every day. Whether it's choosing nutritious foods or finding joy in outdoor activities, taking small steps can lead to significant improvements in your overall well-being. Remember, your journey to better health is a marathon, not a sprint.",
                            PublishedAt = new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5013),
                            Title = "First Post",
                            UpdatedAt = new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5014)
                        },
                        new
                        {
                            Id = new Guid("a3cc8e5b-39a1-4818-81c9-ff1cfb12a1df"),
                            Content = "Exploring new places broadens your horizons and enriches your life in ways you can't imagine. From the bustling streets of vibrant cities to the serene beauty of remote landscapes, every destination has a story to tell. So, pack your bags, embrace the adventure, and let the world be your teacher.",
                            PublishedAt = new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5015),
                            Title = "Second Post",
                            UpdatedAt = new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5016)
                        },
                        new
                        {
                            Id = new Guid("0a1fefbc-e4c4-488e-a57c-2aa79bdc09fe"),
                            Content = "Personal growth is a lifelong journey of self-discovery and self-improvement. It's about embracing change, learning from experiences, and continuously evolving into the best version of yourself. Remember, progress may be slow at times, but every step forward is a step closer to your goals.",
                            PublishedAt = new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5017),
                            Title = "Third Post",
                            UpdatedAt = new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5017)
                        },
                        new
                        {
                            Id = new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e"),
                            Content = "Strong and meaningful relationships are the cornerstone of a fulfilling life. Cultivate connections that are built on trust, communication, and mutual respect. These bonds will provide unwavering support and joy through life's ups and downs.",
                            PublishedAt = new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5019),
                            Title = "Forth Post",
                            UpdatedAt = new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5020)
                        },
                        new
                        {
                            Id = new Guid("f718ef9e-83e7-4413-a6bb-591b2ee9f256"),
                            Content = "Creativity knows no bounds, and it resides within each of us. Whether you express it through art, writing, music, or any other form, don't hesitate to let your imagination run wild. Your unique creative voice has the power to inspire, uplift, and change the world.",
                            PublishedAt = new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5021),
                            Title = "Fifth Post",
                            UpdatedAt = new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5021)
                        },
                        new
                        {
                            Id = new Guid("d1c6e166-cc78-4ce7-b7ae-86b4b4cb01cc"),
                            Content = "The planet we call home needs our care and attention now more than ever. Embracing sustainable practices in our daily lives, from reducing waste to conserving energy, is not just a choice but a responsibility. Together, we can create a greener and healthier future for generations to come.",
                            PublishedAt = new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5022),
                            Title = "Sixst Post",
                            UpdatedAt = new DateTime(2023, 9, 6, 10, 15, 40, 547, DateTimeKind.Local).AddTicks(5023)
                        });
                });

            modelBuilder.Entity("AspNetMvcBlogv2.Data.Entity.PostComment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("PostComment");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4fc61f6a-a99c-4278-8786-1250a61126ea"),
                            Content = "Your smile is absolutely radiant, lighting up the entire page!",
                            PostId = new Guid("156443ea-bfbe-4ee0-b0b3-01fafae69be2"),
                            UserId = new Guid("90da4d80-ebc8-4f54-919d-35781aa4719d")
                        },
                        new
                        {
                            Id = new Guid("714f0953-a0d1-4045-a599-59ef8e458900"),
                            Content = "What a charming face, your positivity is contagious!",
                            PostId = new Guid("a3cc8e5b-39a1-4818-81c9-ff1cfb12a1df"),
                            UserId = new Guid("7eef1f9e-47b9-4d2f-94fb-a5a025146f83")
                        },
                        new
                        {
                            Id = new Guid("bd09236e-6608-4267-8359-0d90072bcd1d"),
                            Content = "You exude such warmth and kindness in every photo.",
                            PostId = new Guid("0a1fefbc-e4c4-488e-a57c-2aa79bdc09fe"),
                            UserId = new Guid("48703ef3-e1b2-449e-bc3f-244c1ff19c53")
                        },
                        new
                        {
                            Id = new Guid("7b17645e-22ac-4da6-a58c-d0b857239f36"),
                            Content = "A truly beautiful face that reflects an equally beautiful soul.",
                            PostId = new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e"),
                            UserId = new Guid("d08101f3-5acb-4aac-a6df-bd0a9be503ff")
                        },
                        new
                        {
                            Id = new Guid("6865eba8-17ca-4d36-8cb0-1ae220901e30"),
                            Content = "Your expressions are a delightful addition to this blog!",
                            PostId = new Guid("f718ef9e-83e7-4413-a6bb-591b2ee9f256"),
                            UserId = new Guid("ff038a80-ec0a-46f7-acea-d6bcd3cdd9a1")
                        },
                        new
                        {
                            Id = new Guid("be03bf8e-f6f3-44fe-bbba-cb426c443e93"),
                            Content = "You've got that perfect combination of grace and charm.",
                            PostId = new Guid("d1c6e166-cc78-4ce7-b7ae-86b4b4cb01cc"),
                            UserId = new Guid("821ba522-d041-42be-882e-59317f5923e4")
                        },
                        new
                        {
                            Id = new Guid("29ecee87-6d61-4f96-9126-ca661a55192e"),
                            Content = "Your face brightens up my day – thank you for sharing your joy!",
                            PostId = new Guid("a3cc8e5b-39a1-4818-81c9-ff1cfb12a1df"),
                            UserId = new Guid("90da4d80-ebc8-4f54-919d-35781aa4719d")
                        },
                        new
                        {
                            Id = new Guid("7986f84e-1e2b-4caa-9dd5-77eb9a0c6d14"),
                            Content = "Each picture tells a story of happiness and positivity.",
                            PostId = new Guid("0a1fefbc-e4c4-488e-a57c-2aa79bdc09fe"),
                            UserId = new Guid("7eef1f9e-47b9-4d2f-94fb-a5a025146f83")
                        },
                        new
                        {
                            Id = new Guid("44e24c6b-4670-424d-8f30-db4577ec76d8"),
                            Content = "Your face is a reflection of the sunshine in your heart.",
                            PostId = new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e"),
                            UserId = new Guid("90da4d80-ebc8-4f54-919d-35781aa4719d")
                        },
                        new
                        {
                            Id = new Guid("af23aa5f-c6d5-444b-9fdf-df986c6e894c"),
                            Content = "Your presence adds a touch of elegance to this blog.",
                            PostId = new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e"),
                            UserId = new Guid("48703ef3-e1b2-449e-bc3f-244c1ff19c53")
                        });
                });

            modelBuilder.Entity("AspNetMvcBlogv2.Data.Entity.PostImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("PostImage");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2455b722-5dba-49bf-add8-6f1c09a6aad0"),
                            ImageUrl = "https://picsum.photos/id/10/150/200",
                            PostId = new Guid("156443ea-bfbe-4ee0-b0b3-01fafae69be2")
                        },
                        new
                        {
                            Id = new Guid("b9d3a013-37fa-4582-aa03-432b9d8f233d"),
                            ImageUrl = "https://picsum.photos/id/11/150/200",
                            PostId = new Guid("a3cc8e5b-39a1-4818-81c9-ff1cfb12a1df")
                        },
                        new
                        {
                            Id = new Guid("5a793c1f-b399-45b9-aecf-9e8579279594"),
                            ImageUrl = "https://picsum.photos/id/12/150/200",
                            PostId = new Guid("0a1fefbc-e4c4-488e-a57c-2aa79bdc09fe")
                        },
                        new
                        {
                            Id = new Guid("84e849ad-fc0a-478c-a7c9-3827772ddb6d"),
                            ImageUrl = "https://picsum.photos/id/13/150/200",
                            PostId = new Guid("89c1337c-d507-41ae-b54e-860cb96ad26e")
                        },
                        new
                        {
                            Id = new Guid("350290aa-5165-4301-999f-983ef01c33fd"),
                            ImageUrl = "https://picsum.photos/id/14/150/200",
                            PostId = new Guid("f718ef9e-83e7-4413-a6bb-591b2ee9f256")
                        },
                        new
                        {
                            Id = new Guid("a13ed4fc-7a2b-430f-b66a-d60dc8816999"),
                            ImageUrl = "https://picsum.photos/id/15/150/200",
                            PostId = new Guid("d1c6e166-cc78-4ce7-b7ae-86b4b4cb01cc")
                        });
                });

            modelBuilder.Entity("AspNetMvcBlogv2.Data.Entity.Setting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Setting");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c210ec57-3c94-4fb8-8f8c-bf710b345a40"),
                            Name = "SiteName",
                            Value = "My Blog"
                        },
                        new
                        {
                            Id = new Guid("9685b51c-5640-4769-a8ec-7f95b366bbc7"),
                            Name = "MaxPostsPerPage",
                            Value = "10"
                        });
                });

            modelBuilder.Entity("AspNetMvcBlogv2.Data.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7eef1f9e-47b9-4d2f-94fb-a5a025146f83"),
                            Email = "test1@gmail.com",
                            Name = "user1",
                            Password = "123",
                            ProfilePictureURL = "https://picsum.photos/id/804/100/100",
                            Surname = "TEST"
                        },
                        new
                        {
                            Id = new Guid("48703ef3-e1b2-449e-bc3f-244c1ff19c53"),
                            Email = "test2@gmail.com",
                            Name = "user2",
                            Password = "123",
                            ProfilePictureURL = "https://picsum.photos/id/807/100/100",
                            Surname = "TEST"
                        },
                        new
                        {
                            Id = new Guid("d08101f3-5acb-4aac-a6df-bd0a9be503ff"),
                            Email = "test3@gmail.com",
                            Name = "user3",
                            Password = "123",
                            ProfilePictureURL = "https://picsum.photos/id/823/100/100",
                            Surname = "TEST"
                        },
                        new
                        {
                            Id = new Guid("ff038a80-ec0a-46f7-acea-d6bcd3cdd9a1"),
                            Email = "test4@gmail.com",
                            Name = "user4",
                            Password = "123",
                            ProfilePictureURL = "https://picsum.photos/id/822/100/100",
                            Surname = "TEST"
                        },
                        new
                        {
                            Id = new Guid("821ba522-d041-42be-882e-59317f5923e4"),
                            Email = "test5@gmail.com",
                            Name = "user5",
                            Password = "123",
                            ProfilePictureURL = "https://picsum.photos/id/832/100/100",
                            Surname = "TEST"
                        },
                        new
                        {
                            Id = new Guid("90da4d80-ebc8-4f54-919d-35781aa4719d"),
                            Email = "test6@gmail.com",
                            Name = "user6",
                            Password = "123",
                            ProfilePictureURL = "https://picsum.photos/id/836/100/100",
                            Surname = "TEST"
                        });
                });

            modelBuilder.Entity("AspNetMvcBlogv2.Data.Entity.CategoryPost", b =>
                {
                    b.HasOne("AspNetMvcBlogv2.Data.Entity.Category", "Category")
                        .WithMany("CategoryPosts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspNetMvcBlogv2.Data.Entity.Post", "Post")
                        .WithMany("CategoryPosts")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("AspNetMvcBlogv2.Data.Entity.PostComment", b =>
                {
                    b.HasOne("AspNetMvcBlogv2.Data.Entity.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspNetMvcBlogv2.Data.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AspNetMvcBlogv2.Data.Entity.PostImage", b =>
                {
                    b.HasOne("AspNetMvcBlogv2.Data.Entity.Post", "Post")
                        .WithMany("Images")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("AspNetMvcBlogv2.Data.Entity.Category", b =>
                {
                    b.Navigation("CategoryPosts");
                });

            modelBuilder.Entity("AspNetMvcBlogv2.Data.Entity.Post", b =>
                {
                    b.Navigation("CategoryPosts");

                    b.Navigation("Comments");

                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
