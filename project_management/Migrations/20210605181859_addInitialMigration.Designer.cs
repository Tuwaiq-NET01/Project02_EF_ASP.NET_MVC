﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project_management.Data;

namespace project_management.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605181859_addInitialMigration")]
    partial class addInitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("project_management.Models.Departement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Departements");
                });

            modelBuilder.Entity("project_management.Models.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("DepId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DepId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("project_management.Models.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("DepId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("ProjectMgrId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DepId");

                    b.HasIndex("ProjectMgrId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("project_management.Models.Task", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<long>("EmpId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProjectId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("EmpId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("project_management.Models.Employee", b =>
                {
                    b.HasOne("project_management.Models.Departement", "Departement")
                        .WithMany()
                        .HasForeignKey("DepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departement");
                });

            modelBuilder.Entity("project_management.Models.Project", b =>
                {
                    b.HasOne("project_management.Models.Departement", "Departement")
                        .WithMany()
                        .HasForeignKey("DepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project_management.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("ProjectMgrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departement");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("project_management.Models.Task", b =>
                {
                    b.HasOne("project_management.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project_management.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });
#pragma warning restore 612, 618
        }
    }
}
