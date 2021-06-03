﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using furnitureStore.Data;

namespace furnitureStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210603122441_CategoryUpdate")]
    partial class CategoryUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("furnitureStore.Models.CardItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Quntity")
                        .HasColumnType("int");

                    b.Property<int>("TotalCost")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CardItems");
                });

            modelBuilder.Entity("furnitureStore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NameOfCategory")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameOfCategory = "Sofa and Tables"
                        },
                        new
                        {
                            Id = 2,
                            NameOfCategory = " Carpet"
                        });
                });

            modelBuilder.Entity("furnitureStore.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("furnitureStore.Models.Furniture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("furnitures");
                });

            modelBuilder.Entity("furnitureStore.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("PaymentType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
