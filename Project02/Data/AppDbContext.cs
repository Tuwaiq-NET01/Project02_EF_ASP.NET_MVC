using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project01.Models;


namespace Project01.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ItemModel> Items { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<CartModel> Carts { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<RoomModel>().Property(r => r.avalibalty).HasDefaultValue("Null");

            //seeding Data into Customer Table
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 1, Name = "Rawabe", Email = "rawabe44u@gmail.com", City = "Hail", Address = "Fahad ALarifi Street", Password = "123456", PhoneNumber = "0560396778" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 2, Name = "Rahaf", Email = "rahaf@gmail.com", City = "Abha", Address = "Ahmed ALarifi Street", Password = "123456", PhoneNumber = "0560396878" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 3, Name = "Reema", Email = "reema@gmail.com", City = "Dammam", Address = "Younis ALarifi Street", Password = "999", PhoneNumber = "0560396798" });

            //seeding data into items table
            modelBuilder.Entity<ItemModel>().HasData(new ItemModel { ID = 1, Name = "Banana", Price = 10, Quantity = 1, Image = "http://cdn.shopify.com/s/files/1/2154/4937/products/banana_600x.jpg?v=1610541466", Description = "Yallow banana from south africa", Type = "Fruit" });
            modelBuilder.Entity<ItemModel>().HasData(new ItemModel { ID = 2, Name = "Banana", Price = 10, Quantity = 1, Image = "http://cdn.shopify.com/s/files/1/2154/4937/products/banana_600x.jpg?v=1610541466", Description = "Yallow banana from south africa", Type = "Fruit" });

            ////seeding data into cart table
            modelBuilder.Entity<CartModel>().HasData(new CartModel { Id = 1, Quantity = 1 });

            modelBuilder.Entity<ItemModel>()
               .HasOne(p => p.Cart)
               .WithMany(b => b.Items)
               .HasForeignKey(p => p.CartId);

        }

    }
}
