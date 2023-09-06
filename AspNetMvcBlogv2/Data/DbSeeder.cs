using AspNetMvcBlogv2.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcBlogv2.Data
{
	public static class DbSeeder
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{
			Guid categoryId1 = Guid.NewGuid();
			Guid categoryId2 = Guid.NewGuid();
			Guid categoryId3 = Guid.NewGuid();
			Guid categoryId4 = Guid.NewGuid();
			Guid categoryId5 = Guid.NewGuid();
			Guid categoryId6 = Guid.NewGuid();

			Guid postId1 = Guid.NewGuid();
			Guid postId2 = Guid.NewGuid();
			Guid postId3 = Guid.NewGuid();
			Guid postId4 = Guid.NewGuid();
			Guid postId5 = Guid.NewGuid();
			Guid postId6 = Guid.NewGuid();

			Guid userId1 = Guid.NewGuid();
			Guid userId2 = Guid.NewGuid();
			Guid userId3 = Guid.NewGuid();
			Guid userId4 = Guid.NewGuid();
			Guid userId5 = Guid.NewGuid();
			Guid userId6 = Guid.NewGuid();

			modelBuilder.Entity<Category>().HasData(
					new Category { Id = categoryId1, Name = "Health and Fitness"  },
					new Category { Id = categoryId2, Name = "Travel and Exploration" },
					new Category { Id = categoryId3, Name = "Personal Growth" },
					new Category { Id = categoryId4, Name = "Relationships" },
					new Category { Id = categoryId5, Name = "Creativity" },
					new Category { Id = categoryId6, Name = "Sustainability" }
			// Add more categories here
			);
			modelBuilder.Entity<Post>().HasData(
					new Post { Id = postId1, Title = "First Post", Content = "Maintaining a healthy lifestyle goes beyond hitting the gym; it's about making mindful choices every day. Whether it's choosing nutritious foods or finding joy in outdoor activities, taking small steps can lead to significant improvements in your overall well-being. Remember, your journey to better health is a marathon, not a sprint.", PublishedAt = DateTime.Now, UpdatedAt = DateTime.Now  },
					new Post { Id = postId2, Title = "Second Post", Content = "Exploring new places broadens your horizons and enriches your life in ways you can't imagine. From the bustling streets of vibrant cities to the serene beauty of remote landscapes, every destination has a story to tell. So, pack your bags, embrace the adventure, and let the world be your teacher.", PublishedAt = DateTime.Now, UpdatedAt = DateTime.Now },
					new Post { Id = postId3, Title = "Third Post", Content = "Personal growth is a lifelong journey of self-discovery and self-improvement. It's about embracing change, learning from experiences, and continuously evolving into the best version of yourself. Remember, progress may be slow at times, but every step forward is a step closer to your goals.", PublishedAt = DateTime.Now, UpdatedAt = DateTime.Now },
					new Post { Id = postId4, Title = "Forth Post", Content = "Strong and meaningful relationships are the cornerstone of a fulfilling life. Cultivate connections that are built on trust, communication, and mutual respect. These bonds will provide unwavering support and joy through life's ups and downs.", PublishedAt = DateTime.Now, UpdatedAt = DateTime.Now },
					new Post { Id = postId5, Title = "Fifth Post", Content = "Creativity knows no bounds, and it resides within each of us. Whether you express it through art, writing, music, or any other form, don't hesitate to let your imagination run wild. Your unique creative voice has the power to inspire, uplift, and change the world.", PublishedAt = DateTime.Now, UpdatedAt = DateTime.Now },
					new Post { Id = postId6, Title = "Sixst Post", Content = "The planet we call home needs our care and attention now more than ever. Embracing sustainable practices in our daily lives, from reducing waste to conserving energy, is not just a choice but a responsibility. Together, we can create a greener and healthier future for generations to come.", PublishedAt = DateTime.Now, UpdatedAt = DateTime.Now }

			);

			modelBuilder.Entity<CategoryPost>().HasData(
		new CategoryPost { CategoryId = categoryId1, PostId = postId1, Id = Guid.NewGuid() },
		new CategoryPost { CategoryId = categoryId2, PostId = postId2, Id = Guid.NewGuid() },
		new CategoryPost { CategoryId = categoryId3, PostId = postId3, Id = Guid.NewGuid() },
		new CategoryPost { CategoryId = categoryId5, PostId = postId4, Id = Guid.NewGuid() },
		new CategoryPost { CategoryId = categoryId4, PostId = postId4, Id = Guid.NewGuid() },
		new CategoryPost { CategoryId = categoryId5, PostId = postId5, Id = Guid.NewGuid() },
		new CategoryPost { CategoryId = categoryId6, PostId = postId6, Id = Guid.NewGuid() }
			);

			modelBuilder.Entity<PostImage>().HasData(
					new PostImage { Id = Guid.NewGuid(), ImageUrl = "https://picsum.photos/id/10/350/350", PostId = postId1 },
					new PostImage { Id = Guid.NewGuid(), ImageUrl = "https://picsum.photos/id/11/350/350", PostId = postId2 },
					new PostImage { Id = Guid.NewGuid(), ImageUrl = "https://picsum.photos/id/12/350/350", PostId = postId3 },
					new PostImage { Id = Guid.NewGuid(), ImageUrl = "https://picsum.photos/id/13/350/350", PostId = postId4 },
					new PostImage { Id = Guid.NewGuid(), ImageUrl = "https://picsum.photos/id/14/350/350", PostId = postId5 },
					new PostImage { Id = Guid.NewGuid(), ImageUrl = "https://picsum.photos/id/15/350/350", PostId = postId6 }

			);

			modelBuilder.Entity<PostComment>().HasData(
		new PostComment { Id = Guid.NewGuid(), Content = "Your smile is absolutely radiant, lighting up the entire page!", PostId = postId1, UserId = userId6 },
		new PostComment { Id = Guid.NewGuid(), Content = "What a charming face, your positivity is contagious!", PostId = postId2, UserId = userId1 },
		new PostComment { Id = Guid.NewGuid(), Content = "You exude such warmth and kindness in every photo.", PostId = postId3, UserId = userId2 },
		new PostComment { Id = Guid.NewGuid(), Content = "A truly beautiful face that reflects an equally beautiful soul.", PostId = postId4, UserId = userId3 },
		new PostComment { Id = Guid.NewGuid(), Content = "Your expressions are a delightful addition to this blog!", PostId = postId5, UserId = userId4 },
		new PostComment { Id = Guid.NewGuid(), Content = "You've got that perfect combination of grace and charm.", PostId = postId6, UserId = userId5 },
		new PostComment { Id = Guid.NewGuid(), Content = "Your face brightens up my day – thank you for sharing your joy!", PostId = postId2, UserId = userId6 },
		new PostComment { Id = Guid.NewGuid(), Content = "Each picture tells a story of happiness and positivity.", PostId = postId3, UserId = userId1 },
		new PostComment { Id = Guid.NewGuid(), Content = "Your face is a reflection of the sunshine in your heart.", PostId = postId4 , UserId = userId6 },
		new PostComment { Id = Guid.NewGuid(), Content = "Your presence adds a touch of elegance to this blog.", PostId = postId4, UserId = userId2 }

);

			modelBuilder.Entity<Page>().HasData(
			new Page { Id = Guid.NewGuid(), Title = "About Us", Content = "The \"About Us\" page on our blogsite is a window into the heart and soul of our digital presence. It's the place where we introduce ourselves, sharing the story behind our passion and purpose. We're not just another website; we're a team of dedicated individuals with a common mission." },
			new Page { Id = Guid.NewGuid(), Title = "Contact", Content = "Whether you have a question, feedback, or a partnership inquiry, our \"Contact\" page is the gateway to reach out to us. We're eager to hear your thoughts, answer your queries, and collaborate with like-minded individuals and organizations who share our passions.\r\n\r\nWe've designed our contact form to be user-friendly, ensuring that your message reaches us without any hassle. Your input is not just welcomed; it's highly appreciated, as it helps us improve and tailor our content to better serve your needs and interests." }

	);
			modelBuilder.Entity<User>().HasData(
				new User { Id = userId1, Name = "user1", Email = "test1@gmail.com", Password = "123", Surname = "TEST", ProfilePictureURL = "https://picsum.photos/id/804/100/100" },
				new User { Id = userId2, Name = "user2", Email = "test2@gmail.com", Password = "123", Surname = "TEST", ProfilePictureURL = "https://picsum.photos/id/807/100/100" },
				new User { Id = userId3, Name = "user3", Email = "test3@gmail.com", Password = "123", Surname = "TEST", ProfilePictureURL = "https://picsum.photos/id/823/100/100" },
				new User { Id = userId4, Name = "user4", Email = "test4@gmail.com", Password = "123", Surname = "TEST", ProfilePictureURL = "https://picsum.photos/id/822/100/100" },
				new User { Id = userId5, Name = "user5", Email = "test5@gmail.com", Password = "123", Surname = "TEST", ProfilePictureURL = "https://picsum.photos/id/832/100/100" },
				new User { Id = userId6, Name = "user6", Email = "test6@gmail.com", Password = "123", Surname = "TEST", ProfilePictureURL = "https://picsum.photos/id/836/100/100" }


		);

			modelBuilder.Entity<Setting>().HasData(
			new Setting { Id = Guid.NewGuid(), Name = "SiteName", Value = "My Blog" },
			new Setting { Id = Guid.NewGuid(), Name = "MaxPostsPerPage", Value = "10" }

	);

		}

	}
}
