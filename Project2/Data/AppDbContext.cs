using Microsoft.EntityFrameworkCore;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterStatus> CharacterStatus { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserFavorite> UserFavorites { get; set; }


        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // character status
            var charstatus1 = new CharacterStatus() { Id = 1, Status = "Alive" };
            var charstatus2 = new CharacterStatus() { Id = 2, Status = "Dead" };

            modelBuilder.Entity<CharacterStatus>().HasData(charstatus1);
            modelBuilder.Entity<CharacterStatus>().HasData(charstatus2);

            // characters
            var character1 = new Character() { Id = 1, Name = "Rick Sanchez", StatusId = 1 };
            var character2 = new Character() { Id = 2, Name = "Morty Smith", StatusId = 2 };

            modelBuilder.Entity<Character>().HasData(character1);
            modelBuilder.Entity<Character>().HasData(character2);

            // users
            var user1 = new User() { Id = 1, Name = "Fahad" };

            modelBuilder.Entity<User>().HasData(user1);

            // user favorites
            modelBuilder.Entity<UserFavorite>().HasKey(c => new { c.UserId, c.CharacterId });

            modelBuilder.Entity<UserFavorite>()
                .HasOne(uf => uf.User)
                .WithMany(c => c.UserFavorites)
                .HasForeignKey(uf => uf.UserId);

            modelBuilder.Entity<UserFavorite>()
                .HasOne(uf => uf.Character)
                .WithMany(p => p.UserFavorites)
                .HasForeignKey(uf => uf.CharacterId);

            var userFavorites1 = new UserFavorite() { UserId = 1, CharacterId = 1 };
            var userFavorites2 = new UserFavorite() { UserId = 1, CharacterId = 2 };

            modelBuilder.Entity<UserFavorite>().HasData(userFavorites1);
            modelBuilder.Entity<UserFavorite>().HasData(userFavorites2);


            ////seed
            //modelBuilder.Entity<Character>().HasData(character1);
            //modelBuilder.Entity<Character>().HasData(character2);

            //modelBuilder.Entity<CharacterStatus>().HasData(charStatus1);
            //modelBuilder.Entity<CharacterStatus>().HasData(charStatus2);


            //modelBuilder.Entity<User>().HasData(user1);

            //modelBuilder.Entity<UserFavorite>().HasData(userFavorites);



            //// relationship many-to-many
            //modelBuilder.Entity<UserFavorite>()
            //    .HasKey(uf => new { uf.UserId, uf.CharacterId });

            //modelBuilder.Entity<UserFavorite>()
            //    .HasOne(uf => uf.User)
            //    .WithMany(c => c.UserFavorites)
            //    .HasForeignKey(uf => uf.UserId);

            //modelBuilder.Entity<UserFavorite>()
            //    .HasOne(uf => uf.Character)
            //    .WithMany(p => p.UserFavorites)
            //    .HasForeignKey(uf => uf.CharacterId);
        }
    }
}
