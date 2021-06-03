using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using furnitureStore.Models;


namespace furnitureStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                NameOfCategory = "Sofa and tabel",
          
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 2,
                NameOfCategory = "Carpet",


            });
            modelBuilder.Entity<Furniture>().HasData(new Furniture
            {
                Id = 1,
               Name= "Sofa ",
               Price = 3000, 
               Image = "https://www.ikea.com/sa/en/images/products/gammalbyn-3-seat-sofa-beige__0868906_pe781416_s5.jpg",


            });
            modelBuilder.Entity<Furniture>().HasData(new Furniture
            {
                Id = 2,
                Name = "Sofa",
                Price = 2500 ,
                Image = "https://media.wired.com/photos/5f6e50f30cb5c0e55736d793/1:1/w_1800,h_1800,c_limit/Gear-Benchmade-Modern-Tyler-Sofa-SOURCE-Benchmade-Modern.jpg",

            });
            modelBuilder.Entity<Furniture>().HasData(new Furniture
            {
                Id = 3,
                Name = "Tabel with 2 seats",
                Price = 600,
                Image = "https://assets.weimgs.com/weimgs/rk/images/wcm/products/202115/0104/tripod-dining-table-walnut-c.jpg",

            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 1,
                FirstName ="Fatimah",
                LastName = "Alqhtnay",
                Address = "Dammam",
                Email = "Fatma.Alqhtnay94@hotmail.com",
                PhoneNumber = 0555906886 ,
            });
            modelBuilder.Entity<Payment>().HasData(new Payment
            {
                Id = 1,
                Amount =22,
                CustomerId = 1 ,
                PaymentType = "Visa Card",
            });
            modelBuilder.Entity<CardItem>().HasData(new CardItem
            {
                Id = 1,
                CustomerId = 1,
                TotalCost = 30000,
                Quntity = 5 ,
            });



        }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<Furniture> furnitures { get; set; }
        public DbSet<CardItem> CardItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> customers { get; set; }

    }
  


}
