﻿// <auto-generated />
using ArtGallery.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtGallery.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605103513_ArtistsDataSeeding")]
    partial class ArtistsDataSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ArtGallery.Models.ArtistModel", b =>
                {
                    b.Property<int>("ArtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ArtBio")
                        .HasColumnType("text");

                    b.Property<string>("ArtImg")
                        .HasColumnType("text");

                    b.Property<string>("ArtName")
                        .HasColumnType("text");

                    b.HasKey("ArtId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtId = 1,
                            ArtBio = "Originally from a small town in the south of Italy Angelo Accardi moved to Napoli to study fine arts at the Art Academy of Naples. Shortly after, in the early 90s, he set up his personal studio close to his childhood home to embark on his pursuit of painting and sculpture. In the course of his artistic development, Accardi has been on a constant search for new sensations using mixed media to depictfigures against differing social backgrounds.",
                            ArtImg = "https://www.angeloaccardi.com/wp-content/uploads/sites/11/2017/12/acardi-620x620-home.jpg",
                            ArtName = "Angelo Accardi"
                        },
                        new
                        {
                            ArtId = 2,
                            ArtBio = "Trained and educated as an artist in the south of France, Benharrouche went on to become a distinguished professor of drawing and painting at Nice´s Academie Paganini. His influences include masters such as Chagall, Picasso, and Miro, yet Benharrouche’s personal style comes through in each of his compositions with much strength, balance and harmony. Deeply spiritual, Yoel Benharrouche establishes a sincere connection with his audience. His vibrant palette and mystical contemplation explore both the historical and spiritual world of Israel. He paints his surroundings with a lyrical quality that has landed him among the elite artists of the world, exploring the duality between the material and the mystical world.",
                            ArtImg = "https://www.eden-gallery.com/wp-content/uploads/sites/15/2017/09/yoel-benharrouche-at-the-studio-105-1-683x1024.jpg",
                            ArtName = "Benharrouche"
                        },
                        new
                        {
                            ArtId = 3,
                            ArtBio = "Born in California in 1965, Tommy studied art history at Santa Monica College in the United States, later on, studying architecture and interior design. His passion for aesthetics drove Tommy to dabble in different fields of design, like high-end furniture and silversmith work, eventually evolving into a painter and artist. Over the years, Tommy became an upscale interior designer, designing projects for high-end clientele.",
                            ArtImg = "https://d2vg5otv6yjmj3.cloudfront.net/wp-content/uploads/2015/12/tommy.jpg",
                            ArtName = "Tommy Shenkar"
                        });
                });

            modelBuilder.Entity("ArtGallery.Models.BuyerModel", b =>
                {
                    b.Property<int>("ByrID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ByrMail")
                        .HasColumnType("text");

                    b.Property<string>("ByrName")
                        .HasColumnType("text");

                    b.Property<int>("ByrPhone")
                        .HasColumnType("int");

                    b.HasKey("ByrID");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("ArtGallery.Models.GalleryModel", b =>
                {
                    b.Property<int>("GlrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GlrImg")
                        .HasColumnType("text");

                    b.Property<string>("GlrLocation")
                        .HasColumnType("text");

                    b.Property<string>("GlrName")
                        .HasColumnType("text");

                    b.HasKey("GlrId");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("ArtGallery.Models.PaintingModel", b =>
                {
                    b.Property<int>("PntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("BuyerId")
                        .HasColumnType("int");

                    b.Property<int>("GalleryId")
                        .HasColumnType("int");

                    b.Property<string>("PntImg")
                        .HasColumnType("text");

                    b.Property<string>("PntName")
                        .HasColumnType("text");

                    b.Property<string>("PntOverview")
                        .HasColumnType("text");

                    b.Property<double>("PntPrice")
                        .HasColumnType("double");

                    b.HasKey("PntId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("BuyerId");

                    b.HasIndex("GalleryId")
                        .IsUnique();

                    b.ToTable("Paintings");
                });

            modelBuilder.Entity("ArtGallery.Models.PaintingModel", b =>
                {
                    b.HasOne("ArtGallery.Models.ArtistModel", "Artist")
                        .WithMany("Paintings")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArtGallery.Models.BuyerModel", "Buyer")
                        .WithMany("Paintings")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArtGallery.Models.GalleryModel", "Gallery")
                        .WithOne("Painting")
                        .HasForeignKey("ArtGallery.Models.PaintingModel", "GalleryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
