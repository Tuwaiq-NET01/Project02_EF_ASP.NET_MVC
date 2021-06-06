using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewcastleUniversity.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace NewcastleUniversity.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions <AppDbContext> options) : base(options)
        {

        }

        //create srudent table in the database and map it into my project
        public DbSet<StudentModel> Students { get; set; }

        //create course table in the database and map it into my project
        public DbSet<CourseModel> Courses { get; set; }

        //create instructor table in the database and map it into my project
        public DbSet<InstructorModel> Instructors { get; set; }

        //create department table in the database and map it into my project
        public DbSet<DepartmentModel> departments { get; set; }

        //create room table in the database and map it into my project
        public DbSet<RoomModel> Rooms { get; set; }

        //create StudentToInstructor MANY_TO_MANY table in the database and map it into my project
        public DbSet<StudentToInstructor> StudentsToInstructors { get; set; }

        //create StudentToCourse MANY_TO_MANY table in the database and map it into my project
        public DbSet<StudentToCourse> StudentsToCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //seeding data in students table for the first time using HasData using override to onMdelCreating
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 1, FullName = "Arwa Wan La", Email = "arwa@uon.edu.au", password = "123" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 2, FullName = "Rahaf Alqahtany", Email = "rahaf@uon.edu.au", password = "wee" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 3, FullName = "Rawabi Alshodukhy", Email = "rawabi@uon.edu.au", password = "qq1122ss" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 4, FullName = "Samerah Alhusainy", Email = "samerah@uon.edu.au", password = "ggg775" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 5, FullName = "Thuraya Alzahrany", Email = "thuraya@uon.edu.au", password = "ggd5223nnf" });

            //seeding Room
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel { Id = 1, RoomNum = 332 });

            //seeding data in courese table for the first time using HasData using override to onMdelCreating
            modelBuilder.Entity<CourseModel>().HasData(new CourseModel { Id = 1, CodeNum = "INFT6060", Name = "Digital Economy", Fee = 1000 });
            modelBuilder.Entity<CourseModel>().HasData(new CourseModel { Id = 2, CodeNum = "GSBS6002", Name = "Foundation of Business Analysis", Fee = 1900 });
            modelBuilder.Entity<CourseModel>().HasData(new CourseModel { Id = 3, CodeNum = "INFT6300", Name = "Game Design", Fee = 2600 });
            modelBuilder.Entity<CourseModel>().HasData(new CourseModel { Id = 4, CodeNum = "INFO6050", Name = "Process Analysis", Fee = 1800 });

            //seeding data in instructor table for the first time using HasData using override to onMdelCreating
            modelBuilder.Entity<InstructorModel>().HasData(new InstructorModel { Id = 1, FullName = "David Jack", Email = "david@uon.edu.au", password = "1258vvfdvdf", PhoneNum = "243212" });
            modelBuilder.Entity<InstructorModel>().HasData(new InstructorModel { Id = 2, FullName = "Peter ", Email = "peter@uon.edu.au", password = "ghghgs556", PhoneNum = "245929" });
            modelBuilder.Entity<InstructorModel>().HasData(new InstructorModel { Id = 3, FullName = "Mark", Email = "mark@uon.edu.au", password = "1258vvfdvdf", PhoneNum = "243956" });

            // seeding data in department table for the first time using HasData using override to onMdelCreating
            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { Id = 1, Name = "Inforamtion Technology" });
            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { Id = 2, Name = "Computer Science" });


            //StudentToInstructor Composite Primary Key {studentId, InstructrId}
            modelBuilder.Entity<StudentToInstructor>().HasKey(si => new { si.StudentId, si.InstructorId });

            //StudentToCourses Composite Primary Key {studentId, InstructrId}
            modelBuilder.Entity<StudentToCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });

            //one to many (department - students) set FK for students which is deprtmaentID
            


        }

    }
}
