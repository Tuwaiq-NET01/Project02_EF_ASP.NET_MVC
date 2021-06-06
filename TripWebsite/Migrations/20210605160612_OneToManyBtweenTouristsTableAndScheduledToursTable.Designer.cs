﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TripWebsite.Data;

namespace TripWebsite.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605160612_OneToManyBtweenTouristsTableAndScheduledToursTable")]
    partial class OneToManyBtweenTouristsTableAndScheduledToursTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
