﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApi.Data;

namespace MovieApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605094657_CreateMovieTable")]
    partial class CreateMovieTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MovieApi.Models.MoiveModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("backdrop_path")
                        .HasColumnType("text");

                    b.Property<int>("budget")
                        .HasColumnType("int");

                    b.Property<string>("imdb_id")
                        .HasColumnType("text");

                    b.Property<string>("overview")
                        .HasColumnType("text");

                    b.Property<string>("poster_path")
                        .HasColumnType("text");

                    b.Property<string>("release_date")
                        .HasColumnType("text");

                    b.Property<int>("revenue")
                        .HasColumnType("int");

                    b.Property<int>("runtime")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.Property<double>("vote_average")
                        .HasColumnType("double");

                    b.HasKey("id");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
