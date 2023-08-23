using AspNetMvcBlogv2.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcBlogv2.Data
{
    public static class DbSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasData(
            new User
            {
                Email = "aras@gmail.com",
                Name = "Aras",
                Password = "123",
                Surname = "Ment",
                Id = Guid.NewGuid()
            },
            new User
            {
                Email = "aksel@gmail.com",
                Name = "Aksel",
                Password = "321",
                Surname = "Ment",
                Id = Guid.NewGuid()
            }


            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CreatedAt = DateTime.Now,
                    Description = "Technological News",
                    Id = Guid.NewGuid(),
                    Name = "Technology",
                    Slug = "Tech",
                    UpdatedAt = DateTime.Now
                },
                new Category
                {
                    CreatedAt = DateTime.Now,
                    Description = "Cooking News",
                    Id = Guid.NewGuid(),
                    Name = "Cooking",
                    Slug = "Cook",
                    UpdatedAt = DateTime.Now
                }
                );

            modelBuilder.Entity<Setting>().HasData(
               new Setting
               {
                    Id = Guid.NewGuid(),
                    Name = "Admin",
                    Value = "True"
               }

               );




        }

    }
}
