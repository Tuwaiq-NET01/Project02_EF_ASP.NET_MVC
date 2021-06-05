﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project02_EF_ASP.NET_MVC.Data;

namespace Project02_EF_ASP.NET_MVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605090924_editCarModel")]
    partial class editCarModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Project02_EF_ASP.NET_MVC.Models.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<string>("color")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Project02_EF_ASP.NET_MVC.Models.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Project02_EF_ASP.NET_MVC.Models.StoreModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("Project02_EF_ASP.NET_MVC.Models.CarModel", b =>
                {
                    b.HasOne("Project02_EF_ASP.NET_MVC.Models.StoreModel", "Store")
                        .WithMany("Cars")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project02_EF_ASP.NET_MVC.Models.CustomerModel", b =>
                {
                    b.HasOne("Project02_EF_ASP.NET_MVC.Models.CarModel", "Car")
                        .WithOne("Customer")
                        .HasForeignKey("Project02_EF_ASP.NET_MVC.Models.CustomerModel", "CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
