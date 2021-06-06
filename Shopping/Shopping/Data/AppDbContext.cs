using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shopping.Models;

namespace Shopping.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // seeding
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel
            {
                ID = 1,
                Name = "Abdullah AL Haif",
                Email = "aalhaif@hotmail.com",
            });

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel
            {
                ID = 2,
                Name = "Batool Alghamdi",
                Email = "batool@gmail.com"
            });


            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel
            {
                ID = 3,
                Name = "Turki Alqurashi",
                Email = "turki@yahoo.com"
            });

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel
            {
                ID = 4,
                Name = "Abdulaziz Almohammadi",
                Email = "ezz@gmail.com"
            });

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel
            {
                ID = 5,
                Name = "Thamer Mashni",
                Email = "Thamer@yahoo.com"
            });

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel
            {
                ID = 6,
                Name = "Sara Alnasser",
                Email = "sara@hotmail.com"
            });

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel
            {
                ID = 7,
                Name = "Abdulrahman Sarawiq",
                Email = "asarawiq@outlook.com"
            });

            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            {
                id = 1,
                name = "iPhone 12 Pro",
                brand = "Apple",
                price = 4199,
                image = "https://images-na.ssl-images-amazon.com/images/I/71MHTD3uL4L._AC_SX679_.jpg"
            });

            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            {
                id = 2,
                name = "iPad Pro",
                brand = "Apple",
                price = 4249,
                image = "https://images-na.ssl-images-amazon.com/images/I/7118Z2RPOdL._AC_SX679_.jpg"
            });

            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            {
                id = 3,
                name = "MacBook Air",
                brand = "Apple",
                price = 4999,
                image = "https://m.media-amazon.com/images/I/71TPda7cwUL._AC_SL1500_.jpg"
            });

            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            {
                id = 4,
                name = "Beats solo3 Wireless Headphones",
                brand = "Apple",
                price = 820,
                image = "https://static.bhphoto.com/images/multiple_images/images500x500/1474305464_IMG_687773.jpg"
            });

            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            {
                id = 5,
                name = "Apple Watch",
                brand = "Apple",
                price = 1499,
                image = "https://cdn.shoplightspeed.com/shops/611777/files/17704548/1500x4000x3/apple-apple-watch-series-5-gps-44mm-gold-aluminum.jpg"
            });

            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            {
                id = 6,
                name = "Apple TV",
                brand = "Apple",
                price = 949,
                image = "https://images-na.ssl-images-amazon.com/images/I/51Y-Dulc3bL._AC_SX569_.jpg"
            });

            modelBuilder.Entity<ServiceModel>().HasData(new ServiceModel
            {
                ID = 1,
                ServiceName = "Maintenance & Parts Replacement",
                Price = 200
            });

            modelBuilder.Entity<ServiceModel>().HasData(new ServiceModel
            {
                ID = 2,
                ServiceName = "Software & Backup",
                Price = 150
            });

            modelBuilder.Entity<ServiceModel>().HasData(new ServiceModel
            {
                ID = 3,
                ServiceName = "One Year Warranty Extension",
                Price = 100
            });

            modelBuilder.Entity<GiftModel>().HasData(new GiftModel
            {
                ID = 1,
                GiftedProduct = "MacBook Air",
                Giver = "Batool Alghamdi",
                Recipient = "Sara Alnasser",

            });

            modelBuilder.Entity<GiftModel>().HasData(new GiftModel
            {
                ID = 2,
                GiftedProduct = "iPad Pro",
                Giver = "Sara Alnasser",
                Recipient = "Batool Alghamdi",

            });

            modelBuilder.Entity<GiftModel>().HasData(new GiftModel
            {
                ID = 3,
                GiftedProduct = "Apple TV",
                Giver = "Abdullaziz Almohammadi",
                Recipient = "Thamer Mashni",

            });

            modelBuilder.Entity<GiftModel>().HasData(new GiftModel
            {
                ID = 4,
                GiftedProduct = "Beats solo3 Wireless Headphones",
                Giver = "Thamer Mashni",
                Recipient = "Turki Alqurashi",

            });

            modelBuilder.Entity<CustomerProduct>()
                .HasKey(bc => new { bc.CustomerID, bc.ProductID });
            modelBuilder.Entity<CustomerProduct>()
                .HasOne(bc => bc.Customer)
                .WithMany(b => b.CustomerProducts)
                .HasForeignKey(bc => bc.CustomerID);
            modelBuilder.Entity<CustomerProduct>()
                .HasOne(bc => bc.Product)
                .WithMany(c => c.CustomerProducts)
                .HasForeignKey(bc => bc.ProductID);

        }
        // Create tables
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<ServiceModel> Services { get; set; }
        public DbSet<GiftModel> Gifts { get; set; }
        public DbSet<CustomerProduct> CustomerProducts { get; set; }


    }
}
