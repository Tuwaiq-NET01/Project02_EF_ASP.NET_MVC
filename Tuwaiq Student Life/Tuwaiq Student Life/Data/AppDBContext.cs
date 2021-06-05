using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tuwaiq_Student_Life.Models;

namespace Tuwaiq_Student_Life.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Room>()
                .Property(r => r.Email)
                .IsRequired();*/
            //seeding
            /*modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 1, FirstName = "Amal", LastName = "Fahad", Email = "Amal@Amal" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 2, FirstName = "Leenah", LastName = "Fahad", Email = "Amal@Amal" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 3, FirstName = "Sarah", LastName = "Fahad", Email = "Amal@Amal" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 4, FirstName = "Reem", LastName = "Fahad", Email = "Amal@Amal" });
            modelBuilder.Entity<StudentModel>().HasData(new StudentModel { Id = 5, FirstName = "Ali", LastName = "Fahad", Email = "Amal@Amal" });

            modelBuilder.Entity<TeacherModel>().HasData(new TeacherModel { Id = 1, Email = "Norah@Norah", FullName = "Norah" });

            modelBuilder.Entity<StudentTeacherModel>().HasData(new StudentTeacherModel { Id = 1, TeacherId = 1, StudentId = 1 });

            modelBuilder.Entity<StudentTeacherModel>().HasData(new StudentTeacherModel { Id = 2, TeacherId = 2, StudentId = 1 });
*/
        }

        public DbSet<InstructorModel> Instructors { get; set; }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<SessionModel> Sessions { get; set; }
        public DbSet<SubjectModel> Subjects { get; set; }
    }
}
