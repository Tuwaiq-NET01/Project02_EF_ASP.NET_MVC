﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TripWebsite.Data;

namespace TripWebsite.Migrations
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

            modelBuilder.Entity("TripWebsite.Models.DestinationsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BriefInformation")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<string>("Img")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BriefInformation = "Downtown ST Paul MN",
                            Date = "2021-06-08",
                            Img = "https://images.unsplash.com/photo-1594872653896-21c0b452d605?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1650&q=80",
                            Name = "Downtown",
                            Price = 400m
                        },
                        new
                        {
                            Id = 2,
                            BriefInformation = "Lake Paul MN",
                            Date = "2021-03-16",
                            Img = "https://images.unsplash.com/photo-1606836131166-5cb137786a8d?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTR8fHRvdXJ8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60",
                            Name = "Lake",
                            Price = 350m
                        },
                        new
                        {
                            Id = 3,
                            BriefInformation = "Oldtown Paul MN",
                            Date = "2021-07-01",
                            Img = "https://images.unsplash.com/photo-1467269204594-9661b134dd2b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDN8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=800&q=60",
                            Name = "Oldtown",
                            Price = 400m
                        },
                        new
                        {
                            Id = 4,
                            BriefInformation = "Museum Paul MN",
                            Date = "2021-06-14",
                            Img = "https://images.unsplash.com/photo-1618604440689-d5465097c6a0?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fG11c3VlbXxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60",
                            Name = "Museum",
                            Price = 350m
                        },
                        new
                        {
                            Id = 5,
                            BriefInformation = "wilds Paul MN",
                            Date = "2021-06-24",
                            Img = "https://images.unsplash.com/photo-1586016413664-864c0dd76f53?ixid=MnwxMjA3fDB8MHxzZWFyY2h8NDB8fHRvdXJ8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60",
                            Name = "wilds",
                            Price = 300m
                        });
                });

            modelBuilder.Entity("TripWebsite.Models.ScheduledToursModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DestinationBriefInformation")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("DestinationDate")
                        .HasColumnType("text");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<string>("DestinationImg")
                        .HasColumnType("text");

                    b.Property<string>("DestinationName")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<decimal>("DestinationPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("TourguiderId")
                        .HasColumnType("int");

                    b.Property<int>("TouristId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId")
                        .IsUnique();

                    b.HasIndex("TourguiderId");

                    b.HasIndex("TouristId");

                    b.ToTable("ScheduledTours");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DestinationBriefInformation = "Downtown ST Paul MN",
                            DestinationDate = "021-06-08",
                            DestinationId = 1,
                            DestinationImg = "https://images.unsplash.com/photo-1594872653896-21c0b452d605?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1650&q=80",
                            DestinationName = "Downtown",
                            DestinationPrice = 400m,
                            TourguiderId = 1,
                            TouristId = 1
                        },
                        new
                        {
                            Id = 2,
                            DestinationBriefInformation = "Lake Paul MN",
                            DestinationDate = "2021-03-16",
                            DestinationId = 2,
                            DestinationImg = "https://images.unsplash.com/photo-1606836131166-5cb137786a8d?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTR8fHRvdXJ8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60",
                            DestinationName = "Lake",
                            DestinationPrice = 350m,
                            TourguiderId = 1,
                            TouristId = 1
                        },
                        new
                        {
                            Id = 3,
                            DestinationBriefInformation = "Oldtown Paul MN",
                            DestinationDate = "2021-07-01",
                            DestinationId = 3,
                            DestinationImg = "https://images.unsplash.com/photo-1467269204594-9661b134dd2b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDN8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=800&q=60",
                            DestinationName = "Oldtown",
                            DestinationPrice = 400m,
                            TourguiderId = 2,
                            TouristId = 4
                        },
                        new
                        {
                            Id = 4,
                            DestinationBriefInformation = "Museum Paul MN",
                            DestinationDate = "2021-06-14",
                            DestinationId = 4,
                            DestinationImg = "https://images.unsplash.com/photo-1618604440689-d5465097c6a0?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fG11c3VlbXxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60",
                            DestinationName = "Museum",
                            DestinationPrice = 350m,
                            TourguiderId = 3,
                            TouristId = 2
                        },
                        new
                        {
                            Id = 5,
                            DestinationBriefInformation = "wilds Paul MN",
                            DestinationDate = "2021-06-24",
                            DestinationId = 5,
                            DestinationImg = "https://images.unsplash.com/photo-1586016413664-864c0dd76f53?ixid=MnwxMjA3fDB8MHxzZWFyY2h8NDB8fHRvdXJ8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60",
                            DestinationName = "wilds",
                            DestinationPrice = 300m,
                            TourguiderId = 5,
                            TouristId = 5
                        });
                });

            modelBuilder.Entity("TripWebsite.Models.TourguidersModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Img")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.ToTable("Tourguiders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Omar work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.",
                            DestinationId = 1,
                            Img = "https://images.unsplash.com/photo-1496302662116-35cc4f36df92?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1650&q=80",
                            Name = "Omar",
                            PhoneNumber = 559898987
                        },
                        new
                        {
                            Id = 2,
                            About = "Sallah work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.",
                            DestinationId = 2,
                            Img = "https://images.unsplash.com/photo-1493863641943-9b68992a8d07?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjZ8fHBlcnNvbnxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60",
                            Name = "Sallah",
                            PhoneNumber = 987644444
                        },
                        new
                        {
                            Id = 3,
                            About = "Mona work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.",
                            DestinationId = 3,
                            Img = "https://images.unsplash.com/photo-1534126506432-a0173ba75bf6?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1650&q=80",
                            Name = "Mona",
                            PhoneNumber = 542122222
                        },
                        new
                        {
                            Id = 4,
                            About = "Khalid work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.",
                            DestinationId = 4,
                            Img = "https://images.unsplash.com/photo-1491555103944-7c647fd857e6?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1650&q=80",
                            Name = "khalid",
                            PhoneNumber = 558888990
                        },
                        new
                        {
                            Id = 5,
                            About = "sara work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.",
                            DestinationId = 5,
                            Img = "https://images.unsplash.com/photo-1603983616619-faf118d6c374?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1650&q=80",
                            Name = "sara",
                            PhoneNumber = 558811111
                        });
                });

            modelBuilder.Entity("TripWebsite.Models.TouristsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Tourists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "afra@gmail.com",
                            Name = "Afra saleh",
                            PhoneNumber = 540000000
                        },
                        new
                        {
                            Id = 2,
                            Email = "yara@gmail.com",
                            Name = "Yara abdulaziz",
                            PhoneNumber = 561111000
                        },
                        new
                        {
                            Id = 3,
                            Email = "maram@gmail.com",
                            Name = "Maram hassan",
                            PhoneNumber = 540003333
                        },
                        new
                        {
                            Id = 4,
                            Email = "duaa@gmail.com",
                            Name = "duaa abdullah",
                            PhoneNumber = 555000000
                        },
                        new
                        {
                            Id = 5,
                            Email = "manar@gmail.com",
                            Name = "manar abdullah",
                            PhoneNumber = 54666669
                        });
                });

            modelBuilder.Entity("TripWebsite.Models.ScheduledToursModel", b =>
                {
                    b.HasOne("TripWebsite.Models.DestinationsModel", "Destination")
                        .WithOne("ScheduledTour")
                        .HasForeignKey("TripWebsite.Models.ScheduledToursModel", "DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TripWebsite.Models.TourguidersModel", "Tourguider")
                        .WithMany("ScheduledTours")
                        .HasForeignKey("TourguiderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TripWebsite.Models.TouristsModel", "Tourist")
                        .WithMany("ScheduledTours")
                        .HasForeignKey("TouristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TripWebsite.Models.TourguidersModel", b =>
                {
                    b.HasOne("TripWebsite.Models.DestinationsModel", "Destination")
                        .WithMany("Tourguiders")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
