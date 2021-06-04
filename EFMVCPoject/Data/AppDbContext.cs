using EFMVCPoject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFMVCPoject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<OrderLineModel> OrderLines { get; set; }
        public DbSet<ProductModel> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { ID = 1,Name = "Saud",Address="Riyadh",OrderID=1 });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { ID = 2, Name = "Mohammed", Address = "Jeddah" ,OrderID=2});
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { ID = 3, Name = "Khalid", Address = "Dammam" ,OrderID=3});

            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { ID = 1, Total=5 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { ID = 2, Total = 13 });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { ID = 3, Total = 1 });

            modelBuilder.Entity<OrderLineModel>().HasData(new OrderLineModel { ID = 1, Quantity=2,Subtotal=30 ,OrderID=1});
            modelBuilder.Entity<OrderLineModel>().HasData(new OrderLineModel { ID = 2, Quantity = 33, Subtotal = 211 , OrderID = 2 });
            modelBuilder.Entity<OrderLineModel>().HasData(new OrderLineModel { ID = 3, Quantity = 3, Subtotal = 12 , OrderID = 3 });

            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { ID = 1, Name = "Mouse", Price = 13 ,OrderLineID=1});
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { ID = 2, Name = "Keyboard", Price = 25,OrderLineID=2 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { ID = 3, Name = "Printer", Price = 7 ,OrderLineID=3});







        }



    }
}
