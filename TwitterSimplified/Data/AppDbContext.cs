using System;
using Microsoft.EntityFrameworkCore;
using TwitterSimplified.Models;
namespace TwitterSimplified.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<TweetModel> Tweets { get; set; }

        public DbSet<LikeModel> Likes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TweetModel>().HasOne(t => t.User).WithMany(u => u.Tweets);

            //User table seeding:
            modelBuilder.Entity<UserModel>().HasData(new UserModel
            {
                Id = 1,
                Username = "BigBoss",
                Email = "bigboss@twitterify.com",
                Password = "nopass"

            });
            modelBuilder.Entity<UserModel>().HasData(new UserModel
            {
                Id = 2,
                Username = "SmallBoss",
                Email = "smallboss@twitterify.com",
                Password = "futureBigboss"
            });


            //seeding profile table:
            modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel
            {
                Id = 1,
                Bio = "Contributing to this futuristic platform",
                UserId = 1
            });
            modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel
            {
                Id = 2,
                Bio = "Hard working",
                UserId = 2
            });


            //seeding tweets table:
            modelBuilder.Entity<TweetModel>().HasData(new TweetModel
            {
                Id = 1,
                Content = "The first tweet!"

            });
            modelBuilder.Entity<TweetModel>().HasData(new TweetModel
            {
                Id = 2,
                Content = "The second tweet!"

            });
            modelBuilder.Entity<TweetModel>().HasData(new TweetModel
            {
                Id = 3,
                Content = "The third tweet!"

            });
            modelBuilder.Entity<TweetModel>().HasData(new TweetModel
            {
                Id = 4,
                Content = "The fourth tweet!"

            });


            //seeding like table:
            modelBuilder.Entity<LikeModel>().HasData(new LikeModel
            {
                Id = 1,
                TweetId = 1,
                UserId = 2
            });
            modelBuilder.Entity<LikeModel>().HasData(new LikeModel
            {
                Id = 2,
                TweetId = 2,
                UserId = 2
            });
            modelBuilder.Entity<LikeModel>().HasData(new LikeModel
            {
                Id = 3,
                TweetId = 3,
                UserId = 1
            });
            modelBuilder.Entity<LikeModel>().HasData(new LikeModel
            {
                Id = 4,
                TweetId = 4,
                UserId = 1
            });

        }
    }
}


