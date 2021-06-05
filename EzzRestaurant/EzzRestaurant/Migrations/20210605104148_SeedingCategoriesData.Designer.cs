﻿// <auto-generated />
using EzzRestaurant.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EzzRestaurant.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605104148_SeedingCategoriesData")]
    partial class SeedingCategoriesData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EzzRestaurant.Models.CategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Img = "https://images.pexels.com/photos/825661/pexels-photo-825661.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Name = "Main Meals"
                        },
                        new
                        {
                            Id = 2,
                            Img = "https://images.pexels.com/photos/209549/pexels-photo-209549.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Name = "Juices"
                        },
                        new
                        {
                            Id = 3,
                            Img = "https://images.pexels.com/photos/4577740/pexels-photo-4577740.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Name = "Entrees"
                        },
                        new
                        {
                            Id = 4,
                            Img = "https://images.pexels.com/photos/5591666/pexels-photo-5591666.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Name = "Breakfast"
                        });
                });

            modelBuilder.Entity("EzzRestaurant.Models.OrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("double");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EzzRestaurant.Models.OrderProductsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("EzzRestaurant.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("img")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EzzRestaurant.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BirthDate")
                        .HasColumnType("text");

                    b.Property<string>("Fname")
                        .HasColumnType("text");

                    b.Property<string>("Lname")
                        .HasColumnType("text");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = "1997-5-31",
                            Fname = "Abdulaziz",
                            Lname = "Almohammadi",
                            PhoneNumber = 582215215
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = "1992-3-03",
                            Fname = "Hussain",
                            Lname = "Alghamdi",
                            PhoneNumber = 555488485
                        });
                });

            modelBuilder.Entity("EzzRestaurant.Models.OrderModel", b =>
                {
                    b.HasOne("EzzRestaurant.Models.UserModel", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EzzRestaurant.Models.OrderProductsModel", b =>
                {
                    b.HasOne("EzzRestaurant.Models.OrderModel", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EzzRestaurant.Models.ProductModel", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EzzRestaurant.Models.ProductModel", b =>
                {
                    b.HasOne("EzzRestaurant.Models.CategoryModel", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
