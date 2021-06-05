using System;
using System.Text;
using System.Linq;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TuwaiqDatabase.Models;
namespace TuwaiqDatabase.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Bootcamp[] bootcamps = new Bootcamp[] {
                new(){ Id=1, Name=".NET Bootcamp", StartDate=new(2021, 04, 06), EndDate=new(2021, 08,15)},
                new(){ Id=2, Name=".Alef Bootcamp", StartDate=new(2021, 10, 03), EndDate=new(2022, 07,25)},
            };

            Class[] classes = new Class[] {
                new(){ Id=1, Name=".NET MVC", BootcampId=1, StartTime=new(2021,06,05, 10,15,30), EndTime = new(2021, 06, 05, 13, 15, 30) },
                new(){ Id=2, Name="React", BootcampId=1, StartTime=new(2021,06,05, 14,15,30), EndTime = new(2021, 06, 05, 17, 15, 30)},
                new(){Id=3,Name="Design Patterns",BootcampId=1,StartTime=new(2021,06,06, 14,15,30),EndTime = new(2021, 06, 06, 17, 15, 30) },
                new(){ Id=4, Name="Unit Testing", BootcampId=1, StartTime=new(2021,06,07, 14,15,30), EndTime = new(2021, 06, 07, 17, 15, 30)},
                new(){ Id=5, Name="Graphic Engines", BootcampId=2, StartTime=new(2021,06,04, 14,15,30), EndTime = new(2021, 06, 04, 17, 15, 30)},
                new(){ Id=6, Name="Unity", BootcampId=2, StartTime=new(2021,06,05, 14,15,30), EndTime = new(2021, 06, 05, 17, 15, 30)},
                new(){ Id=7, Name="Pixel Art", BootcampId=2, StartTime=new(2021,06,06, 14,15,30), EndTime = new(2021, 06, 06, 17, 15, 30)},
            };

            Student[] students = new Student[]{
                new(){Id=1,Name="Khalid", Bootcamp=1},
                new(){Id=2,Name="Mohammed", Bootcamp=1},
                new(){Id=3,Name="Abdulrahman", Bootcamp=1},
                new(){Id=4,Name="Nawal", Bootcamp=1},
                new(){Id=5,Name="Maha", Bootcamp=1},
                new(){Id=6,Name="Joharah", Bootcamp=1},
            };

            Instructor[] instructors = new Instructor[]{
                new(){Id=1,Name="Abdullah", Expertise="C",JoinDate=new(2018,04,11), ClassId=classes[0].Id },
                new(){Id=2,Name="Mishal", Expertise="Java",JoinDate=new(2019,12,24), ClassId=classes[1].Id},
                new(){Id=3,Name="Norah", Expertise="Design Patterns",JoinDate=new(2019,05,21), ClassId=classes[2].Id },
                new(){Id=4,Name="Sarah", Expertise="iOS", JoinDate=new(2018,01,01), ClassId=classes[5].Id},
                new(){Id=5,Name="Lamya", Expertise="Android", JoinDate=new(2019,01,01), ClassId=classes[6].Id},
                new(){Id=6,Name="Nouf", Expertise="Unit Testing", JoinDate=new(2020,01,01), ClassId=classes[3].Id},
                new(){Id=7,Name="Moath", Expertise="Graphics", JoinDate=new(2019,02,01), ClassId=classes[4].Id},
            };

            classes[0].InstructorId = 1;
            classes[1].InstructorId = 2;
            classes[2].InstructorId = 3;
            classes[3].InstructorId = 6;
            classes[4].InstructorId = 7;
            classes[5].InstructorId = 4;
            classes[6].InstructorId = 5;

            modelBuilder.Entity<Instructor>().HasData(instructors);
            modelBuilder.Entity<Bootcamp>().HasData(bootcamps);
            modelBuilder.Entity<Class>().HasData(classes);
            modelBuilder.Entity<Student>().HasData(students);
        }

        public DbSet<Bootcamp> Bootcamps { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}