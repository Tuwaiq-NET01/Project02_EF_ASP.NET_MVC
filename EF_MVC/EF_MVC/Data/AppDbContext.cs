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

        }
    }
}
