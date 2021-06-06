﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project2.Data;

namespace Project2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210606111937_InitialMigration5")]
    partial class InitialMigration5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Project2.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Rick Sanchez",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Morty Smith",
                            StatusId = 2
                        });
                });

            modelBuilder.Entity("Project2.Models.CharacterStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CharacterStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Status = "Alive"
                        },
                        new
                        {
                            Id = 2,
                            Status = "Dead"
                        });
                });

            modelBuilder.Entity("Project2.Models.Character", b =>
                {
                    b.HasOne("Project2.Models.CharacterStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
