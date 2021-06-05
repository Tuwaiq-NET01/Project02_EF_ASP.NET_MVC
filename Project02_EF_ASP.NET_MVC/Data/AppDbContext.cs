using System;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Project02_EF_ASP.NET_MVC.Models;
namespace Project02_EF_ASP.NET_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<CarModel> Cars { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<StoreModel> Store { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StoreModel>().HasData(new StoreModel { Id = 1, Name = "Store 1", Address = "Jeddah" });
            modelBuilder.Entity<StoreModel>().HasData(new StoreModel { Id = 2, Name = "Store 2", Address = "Riyadh" });

            //CarCategory Seeding
            modelBuilder.Entity<CategoryModel>().HasData(new CategoryModel { Id = 1, Name = "Electric" });
            modelBuilder.Entity<CategoryModel>().HasData(new CategoryModel { Id = 2, Name = "Gasoline" });
            modelBuilder.Entity<CategoryModel>().HasData(new CategoryModel { Id = 3, Name = "Diesel" });


            //CarModel Seeding
            var ids = 1;
            var car = new Faker<CarModel>()
                .RuleFor(m => m.Id, f => ids++)
                .RuleFor(m => m.Manufacturer, f => f.Vehicle.Manufacturer())
                .RuleFor(m => m.Model, f => f.Vehicle.Model())
                .RuleFor(m => m.Type, f => f.Vehicle.Type())
                .RuleFor(m => m.color, f => f.Commerce.Color())
                .RuleFor(m => m.StoreId, f => f.Random.Number(1, 2))
                .RuleFor(m => m.CategoryID, f => f.Random.Number(1, 3));

            modelBuilder
               .Entity<CarModel>()
               .HasData(car.Generate(25));

            //Customers Seeding
             ids = 1;
            var carIds = 1;
            var customerFaker = new Faker<CustomerModel>()
                .RuleFor(m => m.Id, f => ids++)
                .RuleFor(m => m.Name, f => f.Name.FullName())
                .RuleFor(m => m.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(m => m.CarId, f => carIds++);

            modelBuilder
               .Entity<CustomerModel>()
               .HasData(customerFaker.Generate(10));
        }

    }
}
