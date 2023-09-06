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
    [Migration("20230906080025_1004_updaepic")]
    partial class _1004_updaepic
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
                            Id = new Guid("c0e13f1d-f7a1-48d7-a45d-ff2b9f1434e9"),
                            Name = "Health and Fitness"
                        },
                        new
                        {
                            Id = new Guid("f911823c-49e0-4df2-b4bf-2e62ec0e26ed"),
                            Name = "Travel and Exploration"
                        },
                        new
                        {
                            Id = new Guid("f590c268-d8ac-400c-b7b3-e07b55b44af4"),
                            Name = "Personal Growth"
                        },
                        new
                        {
                            Id = new Guid("af8ad34d-fbbd-4b1f-b200-494c1f5f6a33"),
                            Name = "Relationships"
                        },
                        new
                        {
                            Id = new Guid("ac0804c8-2312-47ef-ba30-a76464d55a7b"),
                            Name = "Creativity"
                        },
                        new
                        {
                            Id = new Guid("8c1ff986-b6f7-4e10-b1db-12404a7a3dd8"),
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
                            CategoryId = new Guid("c0e13f1d-f7a1-48d7-a45d-ff2b9f1434e9"),
                            PostId = new Guid("439dade8-50bd-4427-9de1-2f6a176f73f0"),
                            Id = new Guid("63e1dee7-0fc8-4cd6-aecb-844aacf99a35")
                        },
                        new
                        {
                            CategoryId = new Guid("f911823c-49e0-4df2-b4bf-2e62ec0e26ed"),
                            PostId = new Guid("66c431f1-ae82-41ff-9a11-cbaa74877261"),
                            Id = new Guid("90136f6e-aa53-4134-ab69-dc203476d2b8")
                        },
                        new
                        {
                            CategoryId = new Guid("f590c268-d8ac-400c-b7b3-e07b55b44af4"),
                            PostId = new Guid("18aab0b6-8118-488e-bdd9-b938e431b5ca"),
                            Id = new Guid("5d96b7f2-21dd-4df8-9275-2263ffab6457")
                        },
                        new
                        {
                            CategoryId = new Guid("ac0804c8-2312-47ef-ba30-a76464d55a7b"),
                            PostId = new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72"),
                            Id = new Guid("29b0a4bc-95f7-47ef-864c-d86b261795df")
                        },
                        new
                        {
                            CategoryId = new Guid("af8ad34d-fbbd-4b1f-b200-494c1f5f6a33"),
                            PostId = new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72"),
                            Id = new Guid("37acf730-2ed0-4962-af90-b024e5f1cece")
                        },
                        new
                        {
                            CategoryId = new Guid("ac0804c8-2312-47ef-ba30-a76464d55a7b"),
                            PostId = new Guid("5d777917-f423-4aff-92ce-81c63a6afe10"),
                            Id = new Guid("33bf0c09-7335-472c-adc7-470757066524")
                        },
                        new
                        {
                            CategoryId = new Guid("8c1ff986-b6f7-4e10-b1db-12404a7a3dd8"),
                            PostId = new Guid("15213c03-52be-4a67-9c04-51ffd7fdf999"),
                            Id = new Guid("ba272e96-1b54-42ee-9f35-e1a98010018d")
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
                            Id = new Guid("52841646-adf3-44e3-9449-1f5b76b571b7"),
                            Content = "The \"About Us\" page on our blogsite is a window into the heart and soul of our digital presence. It's the place where we introduce ourselves, sharing the story behind our passion and purpose. We're not just another website; we're a team of dedicated individuals with a common mission.",
                            Title = "About Us"
                        },
                        new
                        {
                            Id = new Guid("83d4a99a-61a7-4d4d-a31b-07b826dbe90e"),
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
                            Id = new Guid("439dade8-50bd-4427-9de1-2f6a176f73f0"),
                            Content = "Maintaining a healthy lifestyle goes beyond hitting the gym; it's about making mindful choices every day. Whether it's choosing nutritious foods or finding joy in outdoor activities, taking small steps can lead to significant improvements in your overall well-being. Remember, your journey to better health is a marathon, not a sprint.",
                            PublishedAt = new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2826),
                            Title = "First Post",
                            UpdatedAt = new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2827)
                        },
                        new
                        {
                            Id = new Guid("66c431f1-ae82-41ff-9a11-cbaa74877261"),
                            Content = "Exploring new places broadens your horizons and enriches your life in ways you can't imagine. From the bustling streets of vibrant cities to the serene beauty of remote landscapes, every destination has a story to tell. So, pack your bags, embrace the adventure, and let the world be your teacher.",
                            PublishedAt = new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2829),
                            Title = "Second Post",
                            UpdatedAt = new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2829)
                        },
                        new
                        {
                            Id = new Guid("18aab0b6-8118-488e-bdd9-b938e431b5ca"),
                            Content = "Personal growth is a lifelong journey of self-discovery and self-improvement. It's about embracing change, learning from experiences, and continuously evolving into the best version of yourself. Remember, progress may be slow at times, but every step forward is a step closer to your goals.",
                            PublishedAt = new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2830),
                            Title = "Third Post",
                            UpdatedAt = new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2831)
                        },
                        new
                        {
                            Id = new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72"),
                            Content = "Strong and meaningful relationships are the cornerstone of a fulfilling life. Cultivate connections that are built on trust, communication, and mutual respect. These bonds will provide unwavering support and joy through life's ups and downs.",
                            PublishedAt = new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2832),
                            Title = "Forth Post",
                            UpdatedAt = new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2833)
                        },
                        new
                        {
                            Id = new Guid("5d777917-f423-4aff-92ce-81c63a6afe10"),
                            Content = "Creativity knows no bounds, and it resides within each of us. Whether you express it through art, writing, music, or any other form, don't hesitate to let your imagination run wild. Your unique creative voice has the power to inspire, uplift, and change the world.",
                            PublishedAt = new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2834),
                            Title = "Fifth Post",
                            UpdatedAt = new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2834)
                        },
                        new
                        {
                            Id = new Guid("15213c03-52be-4a67-9c04-51ffd7fdf999"),
                            Content = "The planet we call home needs our care and attention now more than ever. Embracing sustainable practices in our daily lives, from reducing waste to conserving energy, is not just a choice but a responsibility. Together, we can create a greener and healthier future for generations to come.",
                            PublishedAt = new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2836),
                            Title = "Sixst Post",
                            UpdatedAt = new DateTime(2023, 9, 6, 11, 0, 25, 796, DateTimeKind.Local).AddTicks(2836)
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
                            Id = new Guid("8adcc08b-bc6b-4413-9bf9-f2a6d27a5925"),
                            Content = "Your smile is absolutely radiant, lighting up the entire page!",
                            PostId = new Guid("439dade8-50bd-4427-9de1-2f6a176f73f0"),
                            UserId = new Guid("91cf8f33-e1d7-4c4b-af0c-a20c2f518233")
                        },
                        new
                        {
                            Id = new Guid("ff664ad2-fdc9-4fb4-8dc2-6b628517b9c0"),
                            Content = "What a charming face, your positivity is contagious!",
                            PostId = new Guid("66c431f1-ae82-41ff-9a11-cbaa74877261"),
                            UserId = new Guid("4d8b7056-9bc9-4c37-94bd-cbd07562fcbd")
                        },
                        new
                        {
                            Id = new Guid("89b06d82-fde3-47cd-ae8b-8a52dae991b1"),
                            Content = "You exude such warmth and kindness in every photo.",
                            PostId = new Guid("18aab0b6-8118-488e-bdd9-b938e431b5ca"),
                            UserId = new Guid("d75116bc-d76b-4eba-8e8a-26ff4cccfbc0")
                        },
                        new
                        {
                            Id = new Guid("e5f08c23-fe0d-455a-925a-09a14287ac4d"),
                            Content = "A truly beautiful face that reflects an equally beautiful soul.",
                            PostId = new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72"),
                            UserId = new Guid("2db3d20f-217d-4bb8-a1f2-4177013da392")
                        },
                        new
                        {
                            Id = new Guid("e14c4d04-134d-4148-a996-7490c5378cf2"),
                            Content = "Your expressions are a delightful addition to this blog!",
                            PostId = new Guid("5d777917-f423-4aff-92ce-81c63a6afe10"),
                            UserId = new Guid("72debf82-a0b0-473b-aed5-ec2d98230db3")
                        },
                        new
                        {
                            Id = new Guid("aa6525ad-3f3a-4dd3-8aad-36c54c292ad1"),
                            Content = "You've got that perfect combination of grace and charm.",
                            PostId = new Guid("15213c03-52be-4a67-9c04-51ffd7fdf999"),
                            UserId = new Guid("a4caba2f-a493-4e41-8148-aeb4ebb89263")
                        },
                        new
                        {
                            Id = new Guid("95b8bd12-be8d-483d-aba8-7e5410e76d57"),
                            Content = "Your face brightens up my day – thank you for sharing your joy!",
                            PostId = new Guid("66c431f1-ae82-41ff-9a11-cbaa74877261"),
                            UserId = new Guid("91cf8f33-e1d7-4c4b-af0c-a20c2f518233")
                        },
                        new
                        {
                            Id = new Guid("4ff0ca7f-7ae7-4347-be84-af3cec52c217"),
                            Content = "Each picture tells a story of happiness and positivity.",
                            PostId = new Guid("18aab0b6-8118-488e-bdd9-b938e431b5ca"),
                            UserId = new Guid("4d8b7056-9bc9-4c37-94bd-cbd07562fcbd")
                        },
                        new
                        {
                            Id = new Guid("3bd34f63-dcdc-42df-a479-5a0cffb8cd14"),
                            Content = "Your face is a reflection of the sunshine in your heart.",
                            PostId = new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72"),
                            UserId = new Guid("91cf8f33-e1d7-4c4b-af0c-a20c2f518233")
                        },
                        new
                        {
                            Id = new Guid("1badb9f3-c015-4dad-b35e-78bc98ad56c4"),
                            Content = "Your presence adds a touch of elegance to this blog.",
                            PostId = new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72"),
                            UserId = new Guid("d75116bc-d76b-4eba-8e8a-26ff4cccfbc0")
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
                            Id = new Guid("b01f978c-ba1c-47b0-9400-094ee299c4ed"),
                            ImageUrl = "https://picsum.photos/id/10/350/350",
                            PostId = new Guid("439dade8-50bd-4427-9de1-2f6a176f73f0")
                        },
                        new
                        {
                            Id = new Guid("ebe6cf98-ca2a-4fde-a890-9d6c2a5d89e4"),
                            ImageUrl = "https://picsum.photos/id/11/350/350",
                            PostId = new Guid("66c431f1-ae82-41ff-9a11-cbaa74877261")
                        },
                        new
                        {
                            Id = new Guid("eb9096dd-620c-4775-9c50-281369a6acb0"),
                            ImageUrl = "https://picsum.photos/id/12/350/350",
                            PostId = new Guid("18aab0b6-8118-488e-bdd9-b938e431b5ca")
                        },
                        new
                        {
                            Id = new Guid("e24a7141-7ba7-48de-8950-fb46594f2b2c"),
                            ImageUrl = "https://picsum.photos/id/13/350/350",
                            PostId = new Guid("27ce695e-eee9-401f-ba67-a4a141a35d72")
                        },
                        new
                        {
                            Id = new Guid("39987fa1-95d8-4af3-ac66-b7366e509ec0"),
                            ImageUrl = "https://picsum.photos/id/14/350/350",
                            PostId = new Guid("5d777917-f423-4aff-92ce-81c63a6afe10")
                        },
                        new
                        {
                            Id = new Guid("cffae535-5db1-4d1f-a2b3-99bca61420c8"),
                            ImageUrl = "https://picsum.photos/id/15/350/350",
                            PostId = new Guid("15213c03-52be-4a67-9c04-51ffd7fdf999")
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
                            Id = new Guid("ce56d7d0-271d-4aaa-b03d-8a2eab27b2ef"),
                            Name = "SiteName",
                            Value = "My Blog"
                        },
                        new
                        {
                            Id = new Guid("e34e8be3-13e0-440f-b6cb-492122b62be9"),
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
                            Id = new Guid("4d8b7056-9bc9-4c37-94bd-cbd07562fcbd"),
                            Email = "test1@gmail.com",
                            Name = "user1",
                            Password = "123",
                            ProfilePictureURL = "https://picsum.photos/id/804/100/100",
                            Surname = "TEST"
                        },
                        new
                        {
                            Id = new Guid("d75116bc-d76b-4eba-8e8a-26ff4cccfbc0"),
                            Email = "test2@gmail.com",
                            Name = "user2",
                            Password = "123",
                            ProfilePictureURL = "https://picsum.photos/id/807/100/100",
                            Surname = "TEST"
                        },
                        new
                        {
                            Id = new Guid("2db3d20f-217d-4bb8-a1f2-4177013da392"),
                            Email = "test3@gmail.com",
                            Name = "user3",
                            Password = "123",
                            ProfilePictureURL = "https://picsum.photos/id/823/100/100",
                            Surname = "TEST"
                        },
                        new
                        {
                            Id = new Guid("72debf82-a0b0-473b-aed5-ec2d98230db3"),
                            Email = "test4@gmail.com",
                            Name = "user4",
                            Password = "123",
                            ProfilePictureURL = "https://picsum.photos/id/822/100/100",
                            Surname = "TEST"
                        },
                        new
                        {
                            Id = new Guid("a4caba2f-a493-4e41-8148-aeb4ebb89263"),
                            Email = "test5@gmail.com",
                            Name = "user5",
                            Password = "123",
                            ProfilePictureURL = "https://picsum.photos/id/832/100/100",
                            Surname = "TEST"
                        },
                        new
                        {
                            Id = new Guid("91cf8f33-e1d7-4c4b-af0c-a20c2f518233"),
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