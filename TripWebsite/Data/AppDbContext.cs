using System;
using Microsoft.EntityFrameworkCore;
using TripWebsite.Models;
using TripWebsite.Data;


namespace TripWebsite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<TouristsModel> Tourists { get; set; }
        public DbSet<TourguidersModel> Tourguiders { get; set; }
        public DbSet<DestinationsModel> Destinations { get; set; }
        public DbSet<ScheduledToursModel> ScheduledTours { get; set; }
        public object TripWebsite { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //seeding Tourists
            modelBuilder.Entity<TouristsModel>().HasData(new TouristsModel { Id = 1, Name = "Afra saleh", PhoneNumber = 0540000000, Email = "afra@gmail.com" });
            modelBuilder.Entity<TouristsModel>().HasData(new TouristsModel { Id = 2, Name = "Yara abdulaziz", PhoneNumber = 0561111000, Email = "yara@gmail.com" });
            modelBuilder.Entity<TouristsModel>().HasData(new TouristsModel { Id = 3, Name = "Maram hassan", PhoneNumber = 0540003333, Email = "maram@gmail.com" });
            modelBuilder.Entity<TouristsModel>().HasData(new TouristsModel { Id = 4, Name = "duaa abdullah", PhoneNumber = 0555000000, Email = "duaa@gmail.com" });
            modelBuilder.Entity<TouristsModel>().HasData(new TouristsModel { Id = 5, Name = "manar abdullah", PhoneNumber = 054666669, Email = "manar@gmail.com" });

            //seeding Destination
            modelBuilder.Entity<DestinationsModel>().HasData(new DestinationsModel { Id = 1, Name = "Downtown", BriefInformation = "Downtown ST Paul MN", Img = "https://images.unsplash.com/photo-1594872653896-21c0b452d605?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1650&q=80", Date = "2021-06-08" , Price = 400 });
            modelBuilder.Entity<DestinationsModel>().HasData(new DestinationsModel { Id = 2, Name = "Lake", BriefInformation = "Lake Paul MN", Img = "https://images.unsplash.com/photo-1606836131166-5cb137786a8d?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTR8fHRvdXJ8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60", Date = "2021-03-16", Price = 350});
            modelBuilder.Entity<DestinationsModel>().HasData(new DestinationsModel { Id = 3, Name = "Oldtown", BriefInformation = "Oldtown Paul MN", Img = "https://images.unsplash.com/photo-1467269204594-9661b134dd2b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDN8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=800&q=60", Date = "2021-07-01", Price = 400 });
            modelBuilder.Entity<DestinationsModel>().HasData(new DestinationsModel { Id = 4, Name = "Museum", BriefInformation = "Museum Paul MN", Img = "https://images.unsplash.com/photo-1618604440689-d5465097c6a0?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fG11c3VlbXxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60", Date = "2021-06-14", Price = 350});
            modelBuilder.Entity<DestinationsModel>().HasData(new DestinationsModel { Id = 5, Name = "wilds", BriefInformation = "wilds Paul MN", Img = "https://images.unsplash.com/photo-1586016413664-864c0dd76f53?ixid=MnwxMjA3fDB8MHxzZWFyY2h8NDB8fHRvdXJ8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60", Date = "2021-06-24", Price = 300});

            //seeding TourguidersModel
            modelBuilder.Entity<TourguidersModel>().HasData(new TourguidersModel { Id = 1, Name = "Omar", DestinationId = 1, About = "Omar work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.", Img = "https://images.unsplash.com/photo-1496302662116-35cc4f36df92?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1650&q=80", PhoneNumber = 0559898987 });
            modelBuilder.Entity<TourguidersModel>().HasData(new TourguidersModel { Id = 2, Name = "Sallah", DestinationId = 2, About = "Sallah work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.", Img = "https://images.unsplash.com/photo-1493863641943-9b68992a8d07?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjZ8fHBlcnNvbnxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60", PhoneNumber = 0987644444 });
            modelBuilder.Entity<TourguidersModel>().HasData(new TourguidersModel { Id = 3, Name = "Mona", DestinationId = 3, About = "Mona work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.", Img = "https://images.unsplash.com/photo-1534126506432-a0173ba75bf6?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1650&q=80", PhoneNumber = 0542122222 });
            modelBuilder.Entity<TourguidersModel>().HasData(new TourguidersModel { Id = 4, Name = "khalid", DestinationId = 4, About = "Khalid work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.", Img = "https://images.unsplash.com/photo-1491555103944-7c647fd857e6?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1650&q=80", PhoneNumber = 0558888990 });
            modelBuilder.Entity<TourguidersModel>().HasData(new TourguidersModel { Id = 5, Name = "sara", DestinationId = 5, About = "sara work in the travel industry, giving guided tours to groups of visitors Guides may give walking tours, bus tours, or even lead river tours on a boat.", Img = "https://images.unsplash.com/photo-1603983616619-faf118d6c374?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1650&q=80", PhoneNumber = 0558811111 });

            //seeding ScheduledToursModel
            modelBuilder.Entity<ScheduledToursModel>().HasData(new ScheduledToursModel { Id = 1, DestinationId = 1 , DestinationName = "Downtown", DestinationBriefInformation = "Downtown ST Paul MN", DestinationImg = "https://images.unsplash.com/photo-1594872653896-21c0b452d605?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1650&q=80", DestinationDate = "021-06-08", DestinationPrice = 400, TourguiderId = 1 , TouristId = 1});
            modelBuilder.Entity<ScheduledToursModel>().HasData(new ScheduledToursModel { Id = 2, DestinationId = 2, DestinationName = "Lake", DestinationBriefInformation = "Lake Paul MN", DestinationImg = "https://images.unsplash.com/photo-1606836131166-5cb137786a8d?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTR8fHRvdXJ8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60", DestinationDate = "2021-03-16", DestinationPrice = 350, TourguiderId = 1, TouristId =1 });
            modelBuilder.Entity<ScheduledToursModel>().HasData(new ScheduledToursModel { Id = 3, DestinationId = 3, DestinationName = "Oldtown", DestinationBriefInformation = "Oldtown Paul MN", DestinationImg = "https://images.unsplash.com/photo-1467269204594-9661b134dd2b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDN8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=800&q=60", DestinationDate = "2021-07-01", DestinationPrice = 400, TourguiderId =2 , TouristId =4 });
            modelBuilder.Entity<ScheduledToursModel>().HasData(new ScheduledToursModel { Id = 4, DestinationId = 4, DestinationName = "Museum", DestinationBriefInformation = "Museum Paul MN", DestinationImg = "https://images.unsplash.com/photo-1618604440689-d5465097c6a0?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fG11c3VlbXxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60", DestinationDate = "2021-06-14", DestinationPrice = 350, TourguiderId = 3, TouristId =2 });
            modelBuilder.Entity<ScheduledToursModel>().HasData(new ScheduledToursModel { Id = 5, DestinationId = 5, DestinationName = "wilds", DestinationBriefInformation = "wilds Paul MN", DestinationImg = "https://images.unsplash.com/photo-1586016413664-864c0dd76f53?ixid=MnwxMjA3fDB8MHxzZWFyY2h8NDB8fHRvdXJ8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=60", DestinationDate = "2021-06-24", DestinationPrice = 300, TourguiderId = 5, TouristId =5 });

        }
    }

    
}