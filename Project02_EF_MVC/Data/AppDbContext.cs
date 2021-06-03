using System;
using Microsoft.EntityFrameworkCore;
using Project02_EF_MVC.Models;

namespace Project02_EF_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //create tables
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentsCourses> StudentsCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////students and courses (many to many relation)
            //modelBuilder.Entity<StudentsCourses>()
            //   .HasOne(t => t.Student)
            //   .WithMany(ts => ts.StudentsCourses)
            //   .HasForeignKey(t => t.StudentId);

            //modelBuilder.Entity<StudentsCourses>()
            //    .HasOne(s => s.Course)
            //    .WithMany(st => st.StudentsCourses)
            //    .HasForeignKey(s => s.CourseId);

            ////teachers
            var teachers = new Teacher[]
            {
            new Teacher{ Id=1, FirstName="Sami",LastName="Aldahlawi"},
            new Teacher{ Id=2, FirstName="Ghada",LastName="Almutairi"},
            new Teacher{ Id=3, FirstName="Hatem", LastName="Alsalman"},
            new Teacher{ Id=4, FirstName="Abdullah",LastName="Altwaim"},
            new Teacher{ Id=5, FirstName="Noora ",LastName="Abdullah"},
            new Teacher{ Id=6, FirstName="Norah",LastName="Mohsen"},
            new Teacher{ Id=7, FirstName="Sarah",LastName="Alqahtani"},
            new Teacher{ Id=8, FirstName="Fai",LastName="Alotaibi"},
            new Teacher{ Id=9, FirstName="Nouf",LastName="Alhassan"}
            };

            //seeding teachers
            foreach (var t in teachers)
            {
                modelBuilder.Entity<Teacher>().HasData(t);

            }


            ////students
            var students = new Student[]
            {
             new Student{Id=1, FirstName="Turki",LastName="Alqurashi"},
             new Student{Id=2, FirstName="Ahmed",LastName="Alzubadi"},
             new Student{Id=3, FirstName="Adel", LastName="Kalu"},
             new Student{Id=4, FirstName="Abdullah",LastName="Al haif"},
            };

            //seeding students
            foreach (var s in students)
            {
                modelBuilder.Entity<Student>().HasData(s);

            }

            ////courses
            var courses = new Course[]
            {
             new Course{Id=1010,Title="ASP.NET"},
             new Course{Id=1020,Title="React"},
             new Course{Id=1030,Title="Unit Testing"},
             new Course{Id=1040,Title="Design Pattern"},
            };

            //seeding courses
            foreach (var c in courses)
            {
                modelBuilder.Entity<Course>().HasData(c);

            }

            //seeding course id to teachers and students
            teachers[0].CourseId = 1010;
            teachers[1].CourseId = 1010;
            teachers[2].CourseId = 1010;

            teachers[3].CourseId = 1020;
            teachers[4].CourseId = 1020;

            teachers[5].CourseId = 1040;
            teachers[6].CourseId = 1040;

            teachers[7].CourseId = 1030;
            teachers[8].CourseId = 1030;


            //seeding data to studentsCourses
            //StudentsCourses s1 = new StudentsCourses() { Id = 1, CourseId = 1010, StudentId = 1 };

            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 1, CourseId = 1010, StudentId = 1 });
            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 2, CourseId = 1020, StudentId = 1 });
            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 3, CourseId = 1030, StudentId = 1 });
            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 4, CourseId = 1040, StudentId = 1 });

            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 5, CourseId = 1010, StudentId = 2 });
            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 6, CourseId = 1020, StudentId = 2 });
            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 7, CourseId = 1030, StudentId = 2 });
            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 8, CourseId = 1040, StudentId = 2 });

            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 9, CourseId = 1010, StudentId = 3 });
            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 10, CourseId = 1020, StudentId = 3 });
            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 11, CourseId = 1030, StudentId = 3 });
            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 12, CourseId = 1040, StudentId = 3 });

            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 13, CourseId = 1010, StudentId = 4 });
            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 14, CourseId = 1020, StudentId = 4 });
            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 15, CourseId = 1030, StudentId = 4 });
            modelBuilder.Entity<StudentsCourses>().HasData(new StudentsCourses() { Id = 16, CourseId = 1040, StudentId = 4 });


        }
    }
}
