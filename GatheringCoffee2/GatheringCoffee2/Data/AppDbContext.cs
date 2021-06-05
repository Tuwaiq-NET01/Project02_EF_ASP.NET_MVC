using GatheringCoffee2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringCoffee2.Data
{
    public class AppDbContext : DbContext
    {
        // connection with database
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){ }


        // creat table
        public DbSet<CoffeeModel> Coffee { get; set; }
        public DbSet<SweetAndFoodModel> SweetAndFood { get; set; }
        public DbSet<CustomerModel> Customer { get; set; }
        public DbSet<CoffeeCategoryModel> CoffeeCategory { get; set; }
        public DbSet<SweetAndFoodCategoryModel> SweetAndFoodCategory { get; set; }
        public DbSet<OrderModel> Order { get; set; }


        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        /*    var hotCoffee = new CoffeeCategoryModel { Id = 1, Name = "Hot Coffee" };
            var coldCoffee = new CoffeeCategoryModel { Id = 2, Name = "Cold Coffee" };*/
            modelBuilder.Entity<CoffeeCategoryModel>().HasData(new CoffeeCategoryModel { Id = 1, Name = "Hot Coffee" });
            modelBuilder.Entity<CoffeeCategoryModel>().HasData(new CoffeeCategoryModel { Id = 2, Name = "Cold Coffee" });

            
            modelBuilder.Entity<CoffeeModel>().HasData(new CoffeeModel { Id = 1, Name = "V60", Description = "the V60 is one of specialty coffee’s favourite brewing methods. Within 3 minutes, you can brew an incredibly tasty coffee.", Price = 18f, Image = "/img/V60.jpeg" , CoffeeCategoryId=1});
            modelBuilder.Entity<CoffeeModel>().HasData(new CoffeeModel { Id = 2, Name = "Chemix", Description = "the Chemex will give you a remarkably clean cup of coffee", Price = 17f, Image = "/img/Chemix.jpeg", CoffeeCategoryId = 1 });
            modelBuilder.Entity<CoffeeModel>().HasData(new CoffeeModel { Id = 3, Name = "Latte", Description = "Amazing milky coffie where the milk is more than the coffie", Price = 15f, Image = "/img/Latte.jpeg", CoffeeCategoryId = 1});
            modelBuilder.Entity<CoffeeModel>().HasData(new CoffeeModel { Id = 4, Name = "Espresso", Description = "Amazing milky coffie where the milk is more than the coffie", Price = 11f, Image = "/img/Espresso.jpeg", CoffeeCategoryId = 1});
            modelBuilder.Entity<CoffeeModel>().HasData(new CoffeeModel { Id = 5, Name = "Cortado", Description = "Amazing milky coffie where the coffie is more than the milk", Price = 14f, Image = "/img/Cortado.jpeg", CoffeeCategoryId = 1 });
            modelBuilder.Entity<CoffeeModel>().HasData(new CoffeeModel { Id = 6, Name = "Spanish-Latte", Description = "The best sweet drink available right now ", Price = 16f, Image = "/img/Spanish-Latte.jpeg", CoffeeCategoryId = 2});
            modelBuilder.Entity<CoffeeModel>().HasData(new CoffeeModel { Id = 7, Name = "Honey-Latte", Description = "The 2nd best sweet drink available right now", Price = 16f, Image = "/img/Honey-Latte.jpeg", CoffeeCategoryId = 2 });
            modelBuilder.Entity<CoffeeModel>().HasData(new CoffeeModel { Id = 8, Name = "ColdPro", Description = "The daily favourite drink ", Price = 21f, Image = "/img/ColdPro.jpeg", CoffeeCategoryId = 2});
            modelBuilder.Entity<CoffeeModel>().HasData(new CoffeeModel { Id = 9, Name = "Strawberry-Moheto", Description = "beautifully assembled summer drink where the strawberry is the main ingrediant", Price = 15f, Image = "/img/Strawberry-Moheto.jpeg", CoffeeCategoryId = 2});
            modelBuilder.Entity<CoffeeModel>().HasData(new CoffeeModel { Id = 10, Name = "Lemon-Moheto", Description = "beautifully assembled summer drink where the lemon is the main ingrediant", Price = 15f, Image = "/img/Lemon-Moheto.jpeg", CoffeeCategoryId = 2});


            modelBuilder.Entity<SweetAndFoodCategoryModel>().HasData(new SweetAndFoodCategoryModel { Id = 1, Name = "Sweet" });
            modelBuilder.Entity<SweetAndFoodCategoryModel>().HasData(new SweetAndFoodCategoryModel { Id = 2, Name = "Food" });

            modelBuilder.Entity<SweetAndFoodModel>().HasData(new SweetAndFoodModel { Id = 1, Name = "Pistachio-cake", Description = "This is the nice Pistachio cake", Price = 28f, Image = "/img/Pistachio-cake.jpeg", SweetAndFoodCategoryId=1 });
            modelBuilder.Entity<SweetAndFoodModel>().HasData(new SweetAndFoodModel { Id = 2, Name = "Brown-cake", Description = "This is the nice Brawn cake", Price = 23f, Image = "/img/Brown-cake.jpeg", SweetAndFoodCategoryId = 1 });
            modelBuilder.Entity<SweetAndFoodModel>().HasData(new SweetAndFoodModel { Id = 3, Name = "Tiramisu-Cake", Description = "This is the nice Tiramisu Cake", Price = 25f, Image = "/img/Tiramisu-Cake.jpg", SweetAndFoodCategoryId = 1 });
            modelBuilder.Entity<SweetAndFoodModel>().HasData(new SweetAndFoodModel { Id = 4, Name = "Haloumi-Sandwish", Description = "This is the nice Haloumi-Sandwish It consists of halloumi added to it, tomatoes, olive oil and thyme", Price = 20f, Image = "/img/Haloumi-Sandwish.jpeg", SweetAndFoodCategoryId = 2 });
            modelBuilder.Entity<SweetAndFoodModel>().HasData(new SweetAndFoodModel { Id = 5, Name = "Croissant", Description = "This is the nice Croissant It consists of nice cheese", Price = 14f, Image = "/img/Croissant.jpeg", SweetAndFoodCategoryId = 2 });
            modelBuilder.Entity<SweetAndFoodModel>().HasData(new SweetAndFoodModel { Id = 6, Name = "Break-Fast", Description = "This is the nice Croissant It consists of nice Labnah dich and Egg dich ", Price = 30f, Image = "/img/Break-Fast.jpeg", SweetAndFoodCategoryId = 2 });
            
            
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 1, Name = "Hussain",PhoneNum="0567800818" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 2, Name = "Meshal", PhoneNum = "0507999706" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { Id = 3, Name = "Thamer", PhoneNum = "0551609938" });


            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 1 , CustomerId= 1 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 2 , CustomerId = 2 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 3 , CustomerId = 3 });
        }



    }

   
}
