using System;
using Crystal_circus.Models;
using Microsoft.EntityFrameworkCore;

namespace Crystal_circus.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
        }
        //create SQL tables
        public DbSet<UserModel> Users { get; set; }
        public DbSet<CreditcardModel> Creditcards { get; set; }
        public DbSet<TicketModel> Tickets { get; set; }
        public DbSet<VenueModel> Venues { get; set; }
        public DbSet<ShowModel> Shows { get; set; }
        public DbSet<PerformerModel> Performers { get; set; }
        //public DbSet<ShowPerformerModel> ShowPerformers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //creditcards
            modelBuilder.Entity<CreditcardModel>().HasData(new CreditcardModel {Id=1,CardNumber=518674827, HolderName="hanan", Date="07/23", CVCNumber=178 });
            modelBuilder.Entity<CreditcardModel>().HasData(new CreditcardModel {Id=2,CardNumber=518624197, HolderName="areej", Date="11/21", CVCNumber=602 });
            modelBuilder.Entity<CreditcardModel>().HasData(new CreditcardModel {Id=3,CardNumber=518602356, HolderName="aryam", Date="03/22", CVCNumber=402 });
            //users
            modelBuilder.Entity<UserModel>().HasData(new UserModel { Id=1,Name="hanan", PhoneNumber=05539572, Email="han@example.com", CreditcardId=1});
            modelBuilder.Entity<UserModel>().HasData(new UserModel { Id=2,Name="ali", PhoneNumber=05012372, Email="ali@example.com", CreditcardId=2});
            modelBuilder.Entity<UserModel>().HasData(new UserModel { Id=3,Name="layla", PhoneNumber=05645339, Email="lay@example.com", CreditcardId=3});
            //Venues
            modelBuilder.Entity<VenueModel>().HasData(new VenueModel { Id= 1, Address= "Zag, Hanover, Germany", Type = "Arena", Image = "https://www.eventim.de/obj/media/DE-eventim/teaser/artworks/2019/young-stage-int-circus-festival-tickets-artwork-2020.jpg" });
            modelBuilder.Entity<VenueModel>().HasData(new VenueModel { Id=2, Address = "QUARTERBACK Immobilien, Leipzig, Germany", Type = "Arena", Image= "https://www.quarterback-immobilien-arena.de/fileadmin/files/_processed_/7/2/csm_03_Tempete_The_Fall-4404_Credit_Cirque_du_Soleil_44bc978214.jpg"});
            //Performer
            modelBuilder.Entity<PerformerModel>().HasData(new PerformerModel { Id = 1, Name= "Cirque du Soleil", Profession="Broadway", PhoneNumber=89357743, Image= "https://www.cirquedusoleil.com/-/media/cds/images/shows/luzia/luzia-highlights/luzia_highlights_canes_1280x853.jpg?db=web&h=853&la=en&vs=1&w=1280&hash=AFCA94652F959A82CDD8D162F70A0BBE2B03813E" });
            modelBuilder.Entity<PerformerModel>().HasData(new PerformerModel { Id = 2, Name = "Reema the clown", Profession = "Clown", PhoneNumber = 05628285, Image = "https://dynaimage.cdn.cnn.com/cnn/c_fill,g_auto,w_1200,h_675,ar_16:9/https%3A%2F%2Fcdn.cnn.com%2Fcnnnext%2Fdam%2Fassets%2F200629130029-cirque-du-soleil-bankrupt.jpg" });
            modelBuilder.Entity<PerformerModel>().HasData(new PerformerModel { Id = 3, Name = "Raneen", Profession = "Magician", PhoneNumber = 056738289, Image = "https://i.cbc.ca/1.5247534.1565824743!/fileImage/httpImage/image.jpg_gen/derivatives/original_780/cirque-du-soleil-luzia.jpg" });
            modelBuilder.Entity<ShowModel>().HasData(new ShowModel { Id = 1, Time = "Sep 22-26, 2021", VenueId= 2});
            modelBuilder.Entity<ShowModel>().HasData(new ShowModel { Id = 2, Time = "Aug 16, 2021", VenueId= 1});
            //ShowPerformer
            modelBuilder.Entity<ShowPerformerModel>().HasData(new ShowPerformerModel { Id = 1, ShowId = 1, PerformerId = 1});
            modelBuilder.Entity<ShowPerformerModel>().HasData(new ShowPerformerModel { Id = 2, ShowId = 2, PerformerId = 2});
            //Tickets
            modelBuilder.Entity<TicketModel>().HasData(new TicketModel { Id = 1, UserId = 2, ShowId = 1 });
            modelBuilder.Entity<TicketModel>().HasData(new TicketModel { Id = 2, UserId = 3, ShowId = 2 });
            modelBuilder.Entity<TicketModel>().HasData(new TicketModel { Id = 3, UserId = 2, ShowId = 1 });
            }
    }
}
