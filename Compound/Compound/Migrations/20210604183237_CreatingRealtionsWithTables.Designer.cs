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
    [Migration("20210604183237_CreatingRealtionsWithTables")]
    partial class CreatingRealtionsWithTables
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

                    b.Property<DateTime>("Event_Date")
                        .HasColumnType("datetime");

                    b.Property<string>("Event_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Event_Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Events");
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
                });

            modelBuilder.Entity("Compound.Models.StaffModel", b =>
                {
                    b.Property<int>("Staff_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Staff_AtWork")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Staff_Name")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Staff_Id");

                    b.HasIndex("UserId");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Compound.Models.UserModel", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("User_Name")
                        .HasColumnType("text");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("User_Id");

                    b.HasIndex("VillaId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Compound.Models.User_EventModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int?>("User_Id")
                        .HasColumnType("int");

                    b.Property<int>("UsertId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("User_Id");

                    b.ToTable("Users_Events");
                });

            modelBuilder.Entity("Compound.Models.VilladModel", b =>
                {
                    b.Property<int>("Villa_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Villa_Group")
                        .HasColumnType("text");

                    b.Property<string>("Villa_Name")
                        .HasColumnType("text");

                    b.Property<int>("Villa_Number")
                        .HasColumnType("int");

                    b.HasKey("Villa_Id");

                    b.ToTable("Villa");
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
                        .HasForeignKey("User_Id");
                });
#pragma warning restore 612, 618
        }
    }
}
