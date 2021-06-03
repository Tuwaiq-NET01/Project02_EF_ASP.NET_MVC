﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using furnitureStore.Data;

namespace furnitureStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Quntity")
                        .HasColumnType("int");

                    b.Property<int>("TotalCost")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

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
                            NameOfCategory = "Sofa and tabel"
                        },
                        new
                        {
                            Id = 2,
                            NameOfCategory = "Carpet"
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Dammam",
                            Email = "Fatma.Alqhtnay94@hotmail.com",
                            FirstName = "Fatimah",
                            LastName = "Alqhtnay",
                            PhoneNumber = 555906886
                        });
                });

            modelBuilder.Entity("furnitureStore.Models.Furniture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategorisId")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("CategorisId");

                    b.ToTable("furnitures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 0,
                            Image = "https://www.ikea.com/sa/en/images/products/gammalbyn-3-seat-sofa-beige__0868906_pe781416_s5.jpg",
                            Name = "Sofa ",
                            Price = 3000.0
                        },
                        new
                        {
                            Id = 2,
                            Category = 0,
                            Image = "https://media.wired.com/photos/5f6e50f30cb5c0e55736d793/1:1/w_1800,h_1800,c_limit/Gear-Benchmade-Modern-Tyler-Sofa-SOURCE-Benchmade-Modern.jpg",
                            Name = "Sofa",
                            Price = 2500.0
                        },
                        new
                        {
                            Id = 3,
                            Category = 0,
                            Image = "https://assets.weimgs.com/weimgs/rk/images/wcm/products/202115/0104/tripod-dining-table-walnut-c.jpg",
                            Name = "Tabel with 2 seats",
                            Price = 600.0
                        });
                });

            modelBuilder.Entity("furnitureStore.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("furnitureStore.Models.CardItem", b =>
                {
                    b.HasOne("furnitureStore.Models.Customer", "Customer")
                        .WithOne("CardItems")
                        .HasForeignKey("furnitureStore.Models.CardItem", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("furnitureStore.Models.Furniture", b =>
                {
                    b.HasOne("furnitureStore.Models.Category", "Categoris")
                        .WithMany("Furnitures")
                        .HasForeignKey("CategorisId");
                });

            modelBuilder.Entity("furnitureStore.Models.Payment", b =>
                {
                    b.HasOne("furnitureStore.Models.Customer", "Customer")
                        .WithOne("payment")
                        .HasForeignKey("furnitureStore.Models.Payment", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
