﻿// <auto-generated />
using System;
using Compound.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Compound.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605134949_AddingImgForStaff")]
    partial class AddingImgForStaff
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Compound.Models.EventModel", b =>
                {
                    b.Property<int>("Event_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Event_Date")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<string>("Event_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Event_Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Event_Id = 1,
                            Event_Date = new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Event_Name = "Musical concert",
                            StaffId = 2
                        },
                        new
                        {
                            Event_Id = 2,
                            Event_Date = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Event_Name = "Gamming Event",
                            StaffId = 5
                        },
                        new
                        {
                            Event_Id = 3,
                            Event_Date = new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Event_Name = "Musical Event",
                            StaffId = 0
                        },
                        new
                        {
                            Event_Id = 4,
                            Event_Date = new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Event_Name = "Hackthon",
                            StaffId = 0
                        },
                        new
                        {
                            Event_Id = 5,
                            Event_Date = new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Event_Name = "Otaku Event",
                            StaffId = 0
                        });
                });

            modelBuilder.Entity("Compound.Models.ServiceModel", b =>
                {
                    b.Property<int>("Service_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Service_Name")
                        .HasColumnType("text");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Service_Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Service_Id = 1,
                            Service_Name = "Clean the swimming pool",
                            StaffId = 4
                        },
                        new
                        {
                            Service_Id = 2,
                            Service_Name = "Preparing the basketball ground play",
                            StaffId = 4
                        },
                        new
                        {
                            Service_Id = 3,
                            Service_Name = "InVilla Service",
                            StaffId = 3
                        },
                        new
                        {
                            Service_Id = 4,
                            Service_Name = "Massage",
                            StaffId = 3
                        },
                        new
                        {
                            Service_Id = 5,
                            Service_Name = "Whatever",
                            StaffId = 3
                        });
                });

            modelBuilder.Entity("Compound.Models.StaffModel", b =>
                {
                    b.Property<int>("Staff_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Staff_AtWork")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Staff_Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Staff_Img")
                        .HasColumnType("text");

                    b.Property<string>("Staff_Name")
                        .HasColumnType("text");

                    b.Property<string>("Staff_PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Staff_Id");

                    b.HasIndex("UserId");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            Staff_Id = 1,
                            Staff_AtWork = false,
                            Staff_Email = "MohammadS@gmail.com",
                            Staff_Img = "https://content.api.news/v3/images/bin/7b790c831c72c5dd3b3275833df09f29",
                            Staff_Name = "Mohammad",
                            Staff_PhoneNumber = "0560908070",
                            UserId = 0
                        },
                        new
                        {
                            Staff_Id = 2,
                            Staff_AtWork = true,
                            Staff_Email = "JhonS@gmail.com",
                            Staff_Img = "https://cdn-0.generatormix.com/images/anime-character/death-the-kid.jpg",
                            Staff_Name = "Jhon",
                            Staff_PhoneNumber = "0576855421",
                            UserId = 0
                        },
                        new
                        {
                            Staff_Id = 3,
                            Staff_AtWork = true,
                            Staff_Email = "AliceS@gmail.com",
                            Staff_Img = "https://animerantshome.files.wordpress.com/2019/08/istj-anime-characters-akame-ga-kill.png?w=600",
                            Staff_Name = "Alice",
                            Staff_PhoneNumber = "0567431473",
                            UserId = 3
                        },
                        new
                        {
                            Staff_Id = 4,
                            Staff_AtWork = true,
                            Staff_Email = "TonyS@gmail.com",
                            Staff_Img = "https://static.fandomspot.com/images/11/10193/00-featured-killua-zoldyck-hunter-x-hunter-anime-preview.jpg",
                            Staff_Name = "Tony",
                            Staff_PhoneNumber = "0576524582",
                            UserId = 3
                        },
                        new
                        {
                            Staff_Id = 5,
                            Staff_AtWork = true,
                            Staff_Email = "JasminS@gmail.com",
                            Staff_Img = "https://vignette.wikia.nocookie.net/akamegakill/images/6/62/Jaegers5.png/revision/latest?cb=20150720195115&path-prefix=ru",
                            Staff_Name = "Jasmin",
                            Staff_PhoneNumber = "0500011123",
                            UserId = 0
                        });
                });

            modelBuilder.Entity("Compound.Models.UserModel", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("User_Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("User_Name")
                        .HasColumnType("text");

                    b.Property<string>("User_PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("User_Id");

                    b.HasIndex("VillaId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            User_Id = 1,
                            User_Email = "ControlS@gmail.com",
                            User_Name = "Abdulrahman",
                            User_PhoneNumber = "0560965772",
                            VillaId = 1
                        },
                        new
                        {
                            User_Id = 2,
                            User_Email = "Ahmad@gmail.com",
                            User_Name = "Ahmad",
                            User_PhoneNumber = "0512312345",
                            VillaId = 1
                        },
                        new
                        {
                            User_Id = 3,
                            User_Email = "Anas@gmail.com",
                            User_Name = "Anas",
                            User_PhoneNumber = "0567324545",
                            VillaId = 1
                        },
                        new
                        {
                            User_Id = 4,
                            User_Email = "Sarah@gmail.com",
                            User_Name = "Sarah",
                            User_PhoneNumber = "0555333642",
                            VillaId = 2
                        },
                        new
                        {
                            User_Id = 5,
                            User_Email = "Amjad@gmail.com",
                            User_Name = "Amjad",
                            User_PhoneNumber = "0553366990",
                            VillaId = 2
                        });
                });

            modelBuilder.Entity("Compound.Models.User_EventModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("Users_Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EventId = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            EventId = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            EventId = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            EventId = 5,
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            EventId = 4,
                            UserId = 5
                        });
                });

            modelBuilder.Entity("Compound.Models.VilladModel", b =>
                {
                    b.Property<int>("Villa_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Villa_Group")
                        .HasColumnType("text");

                    b.Property<string>("Villa_Img")
                        .HasColumnType("text");

                    b.Property<string>("Villa_Name")
                        .HasColumnType("text");

                    b.Property<int>("Villa_Number")
                        .HasColumnType("int");

                    b.HasKey("Villa_Id");

                    b.ToTable("Villa");

                    b.HasData(
                        new
                        {
                            Villa_Id = 1,
                            Villa_Group = "A",
                            Villa_Img = "https://q-xx.bstatic.com/images/hotel/max1024x768/163/163300408.jpg",
                            Villa_Name = "Al-Azhar",
                            Villa_Number = 1
                        },
                        new
                        {
                            Villa_Id = 2,
                            Villa_Group = "A",
                            Villa_Img = "https://cf.bstatic.com/images/hotel/max1024x768/256/256451213.jpg",
                            Villa_Name = "Al-Khair",
                            Villa_Number = 2
                        },
                        new
                        {
                            Villa_Id = 3,
                            Villa_Group = "B",
                            Villa_Img = "https://assets.entrepreneur.com/content/3x2/2000/1604135072-webaliser--TPTXZd9mOo-unsplash.jpg",
                            Villa_Name = "Al-Khaliej",
                            Villa_Number = 3
                        },
                        new
                        {
                            Villa_Id = 4,
                            Villa_Group = "C",
                            Villa_Img = "https://images.traum-ferienwohnungen.de/277125/8501414/46/villa-blanka.jpg",
                            Villa_Name = "Al-Rabea",
                            Villa_Number = 4
                        },
                        new
                        {
                            Villa_Id = 33,
                            Villa_Group = "D",
                            Villa_Img = "https://images.traum-ferienwohnungen.de/266108/7923121/46/villa-1.jpg",
                            Villa_Name = "Al-Hamdanyah",
                            Villa_Number = 5
                        });
                });

            modelBuilder.Entity("Compound.Models.EventModel", b =>
                {
                    b.HasOne("Compound.Models.StaffModel", "Staff")
                        .WithMany("Events")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Compound.Models.ServiceModel", b =>
                {
                    b.HasOne("Compound.Models.StaffModel", "Staff")
                        .WithMany("Services")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Compound.Models.StaffModel", b =>
                {
                    b.HasOne("Compound.Models.UserModel", "User")
                        .WithMany("Staff")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Compound.Models.UserModel", b =>
                {
                    b.HasOne("Compound.Models.VilladModel", "Villa")
                        .WithMany("User")
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Compound.Models.User_EventModel", b =>
                {
                    b.HasOne("Compound.Models.EventModel", "Event")
                        .WithMany("User_Event_list")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Compound.Models.UserModel", "User")
                        .WithMany("User_Event_list")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
