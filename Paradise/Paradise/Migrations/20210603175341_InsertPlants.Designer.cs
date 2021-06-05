﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Paradise.Data;

namespace Paradise.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210603175341_InsertPlants")]
    partial class InsertPlants
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Paradise.Models.Care", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LevelCare")
                        .HasColumnType("text");

                    b.Property<string>("Place")
                        .HasColumnType("text");

                    b.Property<string>("Size")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Cares");
                });

            modelBuilder.Entity("Paradise.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Paradise.Models.Flower", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Tempreture")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Flowers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Image = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/pink-dahlias-royalty-free-image-513204805-1562778270.jpg?crop=0.445xw:1.00xh;0.450xw,0&resize=980:*",
                            Name = "Dahlias",
                            Tempreture = "20°–22°C"
                        },
                        new
                        {
                            ID = 2,
                            Image = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/cornflowers-royalty-free-image-104696040-1562778695.jpg?crop=0.445xw:1.00xh;0.386xw,0&resize=980:*",
                            Name = "Cornflower",
                            Tempreture = "15°-26°C"
                        },
                        new
                        {
                            ID = 3,
                            Image = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/cosmos-flowers-royalty-free-image-184971248-1562779148.jpg?crop=0.445xw:1.00xh;0.382xw,0&resize=980:*",
                            Name = "Cosmos",
                            Tempreture = "16°C"
                        },
                        new
                        {
                            ID = 4,
                            Image = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/verbena-royalty-free-image-471346036-1562778134.jpg?crop=0.445xw:1.00xh;0.439xw,0&resize=980:*",
                            Name = "Verbena",
                            Tempreture = "15°C"
                        },
                        new
                        {
                            ID = 5,
                            Image = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/colchicum-autumnale-autumn-crocus-1532630291.jpg?crop=0.4449685534591195xw:1xh;center,top&resize=980:*",
                            Name = "Colchicum",
                            Tempreture = "20°-25°C"
                        },
                        new
                        {
                            ID = 6,
                            Image = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/purple-aster-daisies-1532630286.jpg?crop=0.447xw:1.00xh;0.366xw,0&resize=980:*",
                            Name = "Asters",
                            Tempreture = "16°–17°C"
                        });
                });

            modelBuilder.Entity("Paradise.Models.Plant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Tempreture")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Plants");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Image = "https://images.unsplash.com/photo-1598880940080-ff9a29891b85?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=700&q=60",
                            Name = "Pothos",
                            Tempreture = "15°-29°C"
                        },
                        new
                        {
                            ID = 2,
                            Image = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1603654887-1427228256-chinese-evergreen-plants-little-water.jpg?crop=0.970xw:0.974xh;0.0208xw,0.0161xh&resize=768:*",
                            Name = "Aglaonema",
                            Tempreture = "18°-24°C"
                        },
                        new
                        {
                            ID = 3,
                            Image = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1603654852-jade-plant-1589561938.jpg?crop=0.6677678150070788xw:1xh;center,top&resize=768:*",
                            Name = "Jade Plant",
                            Tempreture = "18°-24°C"
                        },
                        new
                        {
                            ID = 4,
                            Image = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1557177323-pilea-peperomioides-money-plant-in-the-pot-single-royalty-free-image-917778022-1557177295.jpg?crop=1.00xw:0.668xh;0,0.269xh&resize=768:*",
                            Name = "Chinese Money Plant",
                            Tempreture = "13°-30°C "
                        },
                        new
                        {
                            ID = 5,
                            Image = "https://images.unsplash.com/photo-1484885192048-9696607347da?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=700&q=60",
                            Name = "Aloe",
                            Tempreture = "13°-27°C"
                        },
                        new
                        {
                            ID = 6,
                            Image = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1557255932-the-sill-potted-plant-calathea-medallion-prospect-black-7-1500x-progressive-1557255913.jpg?crop=1.00xw:0.774xh;0,0.174xh&resize=768:*",
                            Name = "Calathea",
                            Tempreture = "15°-23°C "
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
