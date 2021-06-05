using System;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<BookModel> Books { get; set; }
        public DbSet<AuthorModel> Authors { get; set; }
        public DbSet<PublisherModel> Publishers { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        //public DbSet<BookAuthorsModel> BookAuthors { get; set; }
        // publisher has many books , book has one publisher: one to many
        // author has many books: many-to many
        // category has many books, book has one categories: one to many

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryModel>().HasData(new CategoryModel {Id = 1, Name = "Biography"});
            modelBuilder.Entity<CategoryModel>().HasData(new CategoryModel {Id = 2, Name = "Education"});
            modelBuilder.Entity<CategoryModel>().HasData(new CategoryModel {Id = 3, Name = "Literature & Fiction"});
            modelBuilder.Entity<CategoryModel>().HasData(new CategoryModel {Id = 4, Name = "History"});

            modelBuilder.Entity<PublisherModel>().HasData(new PublisherModel {Id = 1, Name = "Penguin Random House"});
            modelBuilder.Entity<PublisherModel>().HasData(new PublisherModel {Id = 2, Name = "Hachette Livre"});
            modelBuilder.Entity<PublisherModel>().HasData(new PublisherModel {Id = 3, Name = "HarperCollins"});
            modelBuilder.Entity<PublisherModel>().HasData(new PublisherModel {Id = 4, Name = "Macmillan Publishers"});
            modelBuilder.Entity<PublisherModel>().HasData(new PublisherModel {Id = 5, Name = "Simon & Schuster"});

            // first book
            modelBuilder.Entity<BookModel>().HasData(new BookModel
            {
                Id = 1, Title = "Northanger Abbey", ISBN = "0-9594-4480-7", PublishedDate = new DateTime(1814, 07, 28),
                Rating = "8.7", PublisherId = 1, CategoryId = 3
            });

            modelBuilder.Entity<AuthorModel>().HasData(new AuthorModel { Id = 1, FirstName = "Jane", LastName = "Austen"});
            modelBuilder.Entity<BookAuthorsModel>().HasData(new BookAuthorsModel {Id = 1, AuthorId = 1, BookId = 1});

            // second book
            modelBuilder.Entity<BookModel>().HasData(new BookModel
            {
                Id = 2, Title = "War and Peace", ISBN = "0-2718-9125-4", PublishedDate = new DateTime(1856, 07, 28),
                Rating = "9", PublisherId = 3, CategoryId = 3
            });

            modelBuilder.Entity<AuthorModel>()
                .HasData(new AuthorModel {Id = 2, FirstName = "Leo", LastName = "Tolstoy"});
            modelBuilder.Entity<BookAuthorsModel>().HasData(new BookAuthorsModel {Id = 2, AuthorId = 2, BookId = 2});

            
            modelBuilder.Entity<BookModel>().HasData(new BookModel
            {
                Id = 3, Title = "Anna Karenina", ISBN = "0-1732-8402-7", PublishedDate = new DateTime(1875, 07, 28),
                Rating = "9", PublisherId = 3, CategoryId = 4
            });
            
            modelBuilder.Entity<BookAuthorsModel>().HasData(new BookAuthorsModel {Id = 3, AuthorId = 2, BookId = 3});


            // 4 book
            modelBuilder.Entity<BookModel>().HasData(new BookModel
            {
                Id = 4, Title = "Mrs. Dalloway", ISBN = "0-2445-3536-1", PublishedDate = new DateTime(1925, 07, 28),
                Rating = "5", PublisherId = 4, CategoryId = 1
            });

            modelBuilder.Entity<AuthorModel>()
                .HasData(new AuthorModel {Id = 3, FirstName = "Virginia", LastName = "Woolf"});
            modelBuilder.Entity<BookAuthorsModel>().HasData(new BookAuthorsModel {Id = 4, AuthorId = 3, BookId = 4});

            // 5 book
            modelBuilder.Entity<BookModel>().HasData(new BookModel
            {
                Id = 5, Title = "Design Patterns: Elements of Reusable Object-Oriented Software", ISBN = "0-4540-7260-0", PublishedDate = new DateTime(1994, 07, 28),
                Rating = "9.2", PublisherId = 4, CategoryId = 2
            });

            modelBuilder.Entity<AuthorModel>()
                .HasData(new AuthorModel {Id = 4, FirstName = "Erich", LastName = "Gamma"});
            modelBuilder.Entity<AuthorModel>()
                .HasData(new AuthorModel {Id = 5, FirstName = "Richard", LastName = "Helm"});
            modelBuilder.Entity<BookAuthorsModel>().HasData(new BookAuthorsModel {Id = 5, AuthorId = 4, BookId = 5});
            modelBuilder.Entity<BookAuthorsModel>().HasData(new BookAuthorsModel {Id = 6, AuthorId = 5, BookId = 5});
        }
    }
}
