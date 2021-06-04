using EF_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        //Create tables
        public DbSet<BookModel> Books { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //seeding 
            modelBuilder.Entity<BookModel>().HasData(new BookModel { Id = 1, Author = "William Golding", Cover = "http://books.google.com/books/content?id=r6eoCwAAQBAJ&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api", Title = "Lord of the Flies" });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { Id = 2, Author = "رضوى عاشور", Cover = "http://books.google.com/books/content?id=ev1KDAAAQBAJ&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api", Title = "ثلاثية غرناطة" });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { Id = 3, Author = "خالد حسيني", Cover = "http://books.google.com/books/content?id=cvPvsgEACAAJ&printsec=frontcover&img=1&zoom=1&source=gbs_api", Title = "و رددت الجبال الصدى" });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { Id = 4, Author = "كيم إكلين", Cover = "http://books.google.com/books/content?id=Of6vDQAAQBAJ&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api", Title = "في ظل الحياة المرئية" });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { Id = 5, Author = "J. K. Rowling", Cover = "http://books.google.com/books/content?id=HksgDQAAQBAJ&printsec=frontcover&img=1&zoom=1&source=gbs_api", Title = "Harry Potter and the Philosopher's Stone" });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { Id = 6, Author = "Antoine de Saint-Exupéry", Cover = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1367545443l/157993.jpg", Title = "The Little Prince" });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { Id = 7, Author = "Matt Haig", Cover = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1602190253l/52578297.jpg", Title = "The Midnight Library" });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { Id = 8, Author = "Emily St. John Mandel", Cover = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1564199892l/45754981.jpg", Title = "The Glass Hotel" });
            modelBuilder.Entity<BookModel>().HasData(new BookModel { Id = 9, Author = "Abi Daré", Cover = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1581128232l/50214741.jpg", Title = "The Girl with the Louding Voice" });


            modelBuilder.Entity<UserModel>().HasData(new UserModel { Id = 1, Email = "raneen.ayman@gmail.com", Password = "1234567" });
            modelBuilder.Entity<UserModel>().HasData(new UserModel { Id = 2, Email = "haneen.Saad@gmail.com", Password = "123456" });
            modelBuilder.Entity<UserModel>().HasData(new UserModel { Id = 3, Email = "Ahmad.Salim@gmail.com", Password = "12345" });
            modelBuilder.Entity<UserModel>().HasData(new UserModel { Id = 4, Email = "Steve.Hobes@gmail.com", Password = "123456" });
            modelBuilder.Entity<UserModel>().HasData(new UserModel { Id = 5, Email = "JoeNadal@gmail.com", Password = "123456" });


            modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel { Id = 1, Name = "Raneen Ayman", UserId = 1, Avatar = "https://semantic-ui.com/images/avatar2/large/molly.png", Bio = "“Books are a uniquely portable magic.” – Stephen King" });
            modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel { Id = 2, Name = "Haneen Saad", UserId = 2, Avatar = "https://semantic-ui.com/images/avatar2/large/kristy.png", Bio = "A good book is an event in my life." });
            modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel { Id = 3, Name = "Ahmad Salim", UserId = 3, Avatar = "https://semantic-ui.com/images/avatar2/large/elyse.png", Bio = "Reading… a vacation for the mind… " });
            modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel { Id = 4, Name = "Steve Hobes", UserId = 4, Avatar = "https://semantic-ui.com/images/avatar/large/steve.jpg", Bio = "Innovation distinguishes between a leader and a follower." });
            modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel { Id = 5, Name = "Joe Nadal", UserId = 5, Avatar = "https://semantic-ui.com/images/avatar/large/jenny.jpg", Bio = "Reading one book is like eating one potato chip" });


            modelBuilder.Entity<ReviewModel>().HasData(new ReviewModel { Id = 1, UserId = 1, BookId = 6, Content = "So amazing. I can see many rereads of this in the years to come." });
            modelBuilder.Entity<ReviewModel>().HasData(new ReviewModel { Id = 2, UserId = 2, BookId = 5, Content = "The BEST of J. K. Rowling" });



        }
    }
}
