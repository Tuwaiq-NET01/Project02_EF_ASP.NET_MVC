using Microsoft.EntityFrameworkCore;
using PlayerReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerReview.Data
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public string desc = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Accusantium quae necessitatibus nostrum ad, obcaecati fugiat quod tempora culpa. Voluptatum qui numquam vero dolorum voluptatibus. Reiciendis quisquam voluptas architecto! Sit, eaque Lorem ipsum dolor sit amet consectetur adipisicing elit. Laboriosam corporis sit accusantium! Unde quae eveniet quam illo aperiam doloribus, eos adipisci, dignissimos, culpa deserunt dolorum iste quia nihil illum atque. Lorem ipsum dolor";
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding company
            modelBuilder.Entity<Company>().HasData(new Company { Id = 1, CompanyName = "Treyarch", Logo = "https://yt3.ggpht.com/ytc/AAUvwnh8dnAnPVNQQqjVbu0FSHFcc2-V0y_v4N738TR-9Q=s900-c-k-c0x00ffffff-no-rj" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 2, CompanyName = "Rockstar", Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Rockstar_Games_Logo.svg/1200px-Rockstar_Games_Logo.svg.png" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 3, CompanyName = "Activision", Logo = "https://lh3.googleusercontent.com/proxy/gLOIG6uMP6dvK3deO3DSW21R4KwuNbKrgI1XF2OQlUrYkiR_IK0gYHAdoPxHDUYC3OW9JfR1RO_BbtuxUpNB_XVwOZX18xhv-eMHC3iC_UO6RsEm_zM_dxd7QS299vo" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 4, CompanyName = "Gurilla Games", Logo = "https://upload.wikimedia.org/wikipedia/en/thumb/1/17/Guerrilla_logo.svg/1200px-Guerrilla_logo.svg.png" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 5, CompanyName = "Ghost Games", Logo = "https://seeklogo.com/images/G/ghost-games-logo-8F6060DF77-seeklogo.com.png" });


            //seeding game
            modelBuilder.Entity<Game>().HasData(new Game { Id = 1, GameName = "Grand Theft Auto", Description = desc, Image = "https://media.rockstargames.com/rockstargames/img/global/news/upload/actual_1421419184.jpg", CompanyId = 2 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 3, GameName = "Black Ops", Description = desc, Image = "https://cdn.europosters.eu/image/750/posters/call-of-duty-black-ops-cover-i8700.jpg", CompanyId = 1 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 4, GameName = "Crash Bandicoot", Description = desc, Image = "https://cdn.europosters.eu/image/750/posters/crash-bandicoot-4-ride-i99518.jpg", CompanyId = 3 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 5, GameName = "Horizon", Description = desc, Image = "https://cdn.europosters.eu/image/750/posters/horizon-zero-dawn-key-art-i34856.jpg", CompanyId = 4 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 6, GameName = "Need for Speed", Description = desc, Image = "https://lh3.googleusercontent.com/proxy/Xb1jfc8iI2vPhYM_N2kvbmCjQIyYc0n6RX2wBGT-MhbXjB63DygrF2vIlyi_3jxajbHsPy9-6u3fPRmadwTWktwEB0ypGLcxjb3O0FWSUt7FFG8ykhJQJiXMj3lmizjSS-tYEIjHy7g", CompanyId = 5 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 2, GameName = "Modern Warfare", Description = desc, Image = "https://m.media-amazon.com/images/M/MV5BMTc3NWY2ZTMtNTNlZC00MWM2LWI5MzYtMmU1YzY0ODk5ZjQ1XkEyXkFqcGdeQXVyODA2MTkwODk@._V1_.jpg", CompanyId = 1 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 7, GameName = "Need for Speed Heat", Description = desc, Image = "https://posterspy.com/wp-content/uploads/2019/12/46a85b70014089.5d717791b29ac.png", CompanyId = 5 });



            //seeding review
            modelBuilder.Entity<Review>().HasData(new Review { Id = 1, Title = "Great Game!", Description = desc, GameId = 3 });
            modelBuilder.Entity<Review>().HasData(new Review { Id = 2, Title = "Extremely fun Game!", Description = desc, GameId = 4});
            modelBuilder.Entity<Review>().HasData(new Review { Id = 3, Title = "Amazing Visuals!", Description = desc, GameId = 5});
            modelBuilder.Entity<Review>().HasData(new Review { Id = 4, Title = "Not that good...", Description = desc, GameId = 6});
            modelBuilder.Entity<Review>().HasData(new Review { Id = 5, Title = "Boring.", Description = desc, GameId = 6});
            modelBuilder.Entity<Review>().HasData(new Review { Id = 6, Title = "Very good.", Description = desc, GameId = 3});
            modelBuilder.Entity<Review>().HasData(new Review { Id = 7, Title = "Great Game!", Description = desc, GameId = 7 });
            modelBuilder.Entity<Review>().HasData(new Review { Id = 8, Title = "Great Game!", Description = desc, GameId = 1 });
            modelBuilder.Entity<Review>().HasData(new Review { Id = 9, Title = "Very great game", Description = desc, GameId = 4 });
            modelBuilder.Entity<Review>().HasData(new Review { Id = 10, Title = "I had so much fun!", Description = desc, GameId = 4 });


            //seeding user
            modelBuilder.Entity<User>().HasData(new User { Id = 1, Username = "Jake", Password="123", Email = "User@example.com", ReviewId= 1});
            modelBuilder.Entity<User>().HasData(new User { Id = 2, Username = "John", Password="123", Email = "User@example.com", ReviewId = 2});
            modelBuilder.Entity<User>().HasData(new User { Id = 3, Username = "Drake", Password="123", Email = "User@example.com", ReviewId = 3 });
            modelBuilder.Entity<User>().HasData(new User { Id = 4, Username = "Michael", Password="123", Email = "User@example.com", ReviewId = 4 });
            modelBuilder.Entity<User>().HasData(new User { Id = 5, Username = "Paul", Password="123", Email = "User@example.com", ReviewId = 5 });
            modelBuilder.Entity<User>().HasData(new User { Id = 6, Username = "Jack", Password="123", Email = "User@example.com", ReviewId = 6 });
            modelBuilder.Entity<User>().HasData(new User { Id = 7, Username = "Jake", Password="123", Email = "User@example.com", ReviewId = 7 });
            modelBuilder.Entity<User>().HasData(new User { Id = 8, Username = "Robert", Password="123", Email = "User@example.com", ReviewId = 8 });
            modelBuilder.Entity<User>().HasData(new User { Id = 9, Username = "Jake", Password="123", Email = "User@example.com", ReviewId = 9 });
            modelBuilder.Entity<User>().HasData(new User { Id = 10, Username = "Jimmy", Password="123", Email = "User@example.com", ReviewId = 10 });

        }



        public DbSet<Game> Games { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users{ get; set; }



    }
}
