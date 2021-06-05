using System;
using BooksStoreMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Termnal instructions
// dotnet ef migrations add  
//dotnet ef database update
//dotnet ef migrations remove
//dotnet ef migrations remove --force
//dotnet ef migrations List

// App dbcontext extend Dbcontext
namespace BooksStoreMVC.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seeding 
            //(run this only once put it as comment after you update database with it)

            //Publishers
            //modelBuilder.Entity<PublisherModel>().HasData(new PublisherModel { PubId = 1, PubPhone = "0555555555", PubName = "Nada Majed" });
            //modelBuilder.Entity<PublisherModel>().HasData(new PublisherModel { PubId = 2, PubPhone = "0555555556", PubName = "Arwa Majed" });
            //modelBuilder.Entity<PublisherModel>().HasData(new PublisherModel { PubId = 3, PubPhone = "0555555557", PubName = "Raghad Majed" });
            //modelBuilder.Entity<PublisherModel>().HasData(new PublisherModel { PubId = 4, PubPhone = "0555555558", PubName = "Lana Majed" });
            //modelBuilder.Entity<PublisherModel>().HasData(new PublisherModel { PubId = 5, PubPhone = "0555555559", PubName = "Nadiyah Nasser" });
            //modelBuilder.Entity<PublisherModel>().HasData(new PublisherModel { PubId = 6, PubPhone = "0555555599", PubName = "Majed Saad" });
            //modelBuilder.Entity<PublisherModel>().HasData(new PublisherModel { PubId = 7, PubPhone = "0555555599", PubName = "Saad Majed" });
            //modelBuilder.Entity<PublisherModel>().HasData(new PublisherModel { PubId = 8, PubPhone = "0555555599", PubName = "Mohammed Abdullah" });

            //Books
            //modelBuilder.Entity<BookModel>().HasData(new BookModel { ISBN = 1234, Title = "C# book", Price = 15.6 });
            //modelBuilder.Entity<BookModel>().HasData(new BookModel { ISBN = 1233, Title = "Java book", Price = 20.9 });6
            //modelBuilder.Entity<BookModel>().HasData(new BookModel { ISBN = 1235, Title = "Design Pattren book", Price = 15.6 });
            //modelBuilder.Entity<BookModel>().HasData(new BookModel { ISBN = 1236, Title = "MVC book", Price = 55 });

            //Contributors
            //modelBuilder.Entity<ContributorModel>().HasData(new ContributorModel { ConID = 1, ConName = "Alzahrah", ConPhone = "0555655654" });
            //modelBuilder.Entity<ContributorModel>().HasData(new ContributorModel { ConID = 2, ConName = "Alolla"  , ConPhone = "0535655654" });
            //modelBuilder.Entity<ContributorModel>().HasData(new ContributorModel { ConID = 3, ConName = "Alressalah", ConPhone = "0545655654" });
            //modelBuilder.Entity<ContributorModel>().HasData(new ContributorModel { ConID = 4, ConName = "Alrwabe", ConPhone = "056655654" });
            //modelBuilder.Entity<ContributorModel>().HasData(new ContributorModel { ConID = 5, ConName = "Jarir", ConPhone = "0575655654" });
            //modelBuilder.Entity<ContributorModel>().HasData(new ContributorModel { ConID = 6, ConName = "Alnada", ConPhone = "0585655654" });
            //modelBuilder.Entity<ContributorModel>().HasData(new ContributorModel { ConID = 7, ConName = "Alketab", ConPhone = "0595655654" });
            //modelBuilder.Entity<ContributorModel>().HasData(new ContributorModel { ConID = 8, ConName = "Alward", ConPhone = "05105655654" });

            //Authors
            //modelBuilder.Entity<AutherModel>().HasData(new AutherModel { AuthId = 1, AuthPhone = "0555555555", AuthName = "Rana Majed" });
            //modelBuilder.Entity<AutherModel>().HasData(new AutherModel { AuthId = 2, AuthPhone = "0555555556", AuthName = "Lama Majed" });
            //modelBuilder.Entity<AutherModel>().HasData(new AutherModel { AuthId = 3, AuthPhone = "0555555557", AuthName = "Saud Majed" });
            //modelBuilder.Entity<AutherModel>().HasData(new AutherModel { AuthId = 4, AuthPhone = "0555555558", AuthName = "Reema Majed" });
            //modelBuilder.Entity<AutherModel>().HasData(new AutherModel { AuthId = 5, AuthPhone = "0555555559", AuthName = "Nawal Nasser" });
            //modelBuilder.Entity<AutherModel>().HasData(new AutherModel { AuthId = 6, AuthPhone = "0555555599", AuthName = "Fatimah Saad" });
            //modelBuilder.Entity<AutherModel>().HasData(new AutherModel { AuthId = 7, AuthPhone = "0555555599", AuthName = "Aishah Majed" });
            //modelBuilder.Entity<AutherModel>().HasData(new AutherModel { AuthId = 8, AuthPhone = "0555555599", AuthName = "Razan Saud" });

            
            modelBuilder.Entity<WrittenByAuthorsBooks>()
                .HasKey(cc => new { cc.AutherId, cc.BookISBN });
            modelBuilder.Entity<WrittenByAuthorsBooks>()
                .HasOne(cc => cc.Auther)
                .WithMany(b => b.WrittenByAuthorsBooks)
                .HasForeignKey(cc => cc.AutherId);
            modelBuilder.Entity<WrittenByAuthorsBooks>()
                .HasOne(cc => cc.Book)
                .WithMany(c => c.WrittenByAuthorsBooks)
                .HasForeignKey(cc => cc.BookISBN);

            // To create sql table
        }
        public DbSet<PublisherModel> Publishers { get; set; }
        public DbSet<BookModel> Books { get; set; }
        public DbSet<ContributorModel> Contributors { get; set; }
        public DbSet<AutherModel> Authers { get; set; }
        public DbSet<WrittenByAuthorsBooks> WrittenByAuthorsBooks { get; set; }

        // dotnet ef migrations add WrittenByAuthorsBooks
       // dotnet ef database update



    }

}
