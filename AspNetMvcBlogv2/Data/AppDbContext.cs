﻿using AspNetMvcBlogv2.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcBlogv2.Data
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<CategoryPost> CategoryPost { get; set; }

        public DbSet<Post> Post { get; set; }

        public DbSet<Page> Page { get; set; }

        public DbSet<PostComment> PostComment { get; set; }

        public DbSet<PostImage> PostImage { get; set; }

        public DbSet<Setting> Setting { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

    }
}