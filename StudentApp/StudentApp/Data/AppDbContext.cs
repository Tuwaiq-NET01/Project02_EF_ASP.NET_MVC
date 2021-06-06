﻿using System;
using Microsoft.EntityFrameworkCore;
using StudentApp.Models;

namespace StudentApp.Data
{
    public class AppDbContext: DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>()
                .HasOne(q => q.Course)
                .WithMany(c => c.Questions);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });


            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourse )
                .HasForeignKey(sc => sc.StudentId );


            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course )
                .WithMany(c => c.StudentCourse)
                .HasForeignKey(sc => sc.CourseId );

            //Students
            modelBuilder.Entity<Student>().HasData(new Student { Id=1,Name="Ahmed",img= "https://previews.123rf.com/images/jemastock/jemastock1710/jemastock171012232/88397537-male-student-carrying-bag-happy-cartoon-icon-image-vector-illustration-design.jpg" }
            );

            modelBuilder.Entity<Student>().HasData(new Student { Id = 2, Name = "Abdulrahman sarawiq", img = "data:image/jpeg;base64,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" });

            modelBuilder.Entity<Student>().HasData(new Student { Id = 3, Name = "Abdulmajeed Almaymuni", img = "https://previews.123rf.com/images/jemastock/jemastock1710/jemastock171011350/88357846-male-student-carrying-bag-happy-cartoon-icon-image-vector-illustration-design.jpg" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 4, Name = "Faisal Alsagri", img = "https://previews.123rf.com/images/jemastock/jemastock1710/jemastock171012232/88397537-male-student-carrying-bag-happy-cartoon-icon-image-vector-illustration-design.jpg" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 5, Name = "Ibrahim Alobaysi", img = "https://d2gg9evh47fn9z.cloudfront.net/800px_COLOURBOX36785218.jpg" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 6, Name = "Turki Alqurashi", img = "https://eversity.edu/wp-content/uploads/2018/07/malestudent.jpg" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 7, Name = "Adel Kalu", img = "https://previews.123rf.com/images/jemastock/jemastock1710/jemastock171012232/88397537-male-student-carrying-bag-happy-cartoon-icon-image-vector-illustration-design.jpg" });
            //female
            modelBuilder.Entity<Student>().HasData(new Student { Id = 8, Name = "Fatimah Alqhtany", img = "https://previews.123rf.com/images/jemastock/jemastock1710/jemastock171011278/88357184-student-carrying-bag-happy-female-cartoon-icon-image-vector-illustration-design.jpg" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 9, Name = "Amal Almotairi", img = "https://previews.123rf.com/images/jemastock/jemastock1710/jemastock171012175/88395766-student-carrying-bag-happy-red-hair-female-cartoon-icon-image-vector-illustration-design.jpg" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 10, Name = "Arwa Wan La", img = "https://previews.123rf.com/images/jemastock/jemastock1710/jemastock171011278/88357184-student-carrying-bag-happy-female-cartoon-icon-image-vector-illustration-design.jpg" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 11, Name = "Albandry AlQaseemi", img = "https://cdn4.vectorstock.com/i/1000x1000/90/68/young-woman-student-cartoon-vector-19619068.jpg" });

            // Courses
            modelBuilder.Entity<Course>().HasData(new Course { Id = 1, Name = ".net", Img = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/.NET_Core_Logo.svg/1200px-.NET_Core_Logo.svg.png" }
            );
            modelBuilder.Entity<Course>().HasData(new Course { Id = 2, Name = "React", Img = "https://ensocore.com/media/61/reactjs-logo-sticker%20%281%29.jpg" }
            );
            modelBuilder.Entity<Course>().HasData(new Course { Id = 3, Name = "DesignPattern", Img = "https://bgasparotto.com/wp-content/uploads/2016/11/design-patterns-logo-2.png" } );
            modelBuilder.Entity<Course>().HasData(new Course { Id = 4, Name = "UintTest", Img = "https://i0.wp.com/modev.net/wp-content/uploads/2018/06/unit-testing.png?resize=1024%2C545&ssl=1" });
            modelBuilder.Entity<Course>().HasData(new Course { Id = 5, Name = "MySql", Img = "https://download.logo.wine/logo/MySQL/MySQL-Logo.wine.png" });


            //Questions
            modelBuilder.Entity<Question>().HasData(new Question { Id = 1, question = "What is the .NET Framework?", Answer = "This is a common way for interviewers to start an interview for a software developer who needs to specialize in the .NET Framework. Show the interviewer your ability to utilize the .NET Framework effectively by describing what it is, when to use it and its main features. Try to show your practical knowledge of the system.", CourseId = 1 });
            modelBuilder.Entity<Question>().HasData(new Question { Id = 2, question = "What is CTS?", Answer = "CTS stands for Common Type System. It follows a set of structured rules according to which a data type should be declared and used in the program code. It is used to describe all the data types that are going to be used in the application.", CourseId = 1 });
            modelBuilder.Entity<Question>().HasData(new Question { Id = 3, question = "What are the most important aspects of .NET?", Answer = ".NET is an infrastructure that consists of multiple features like application domain, a common type system and profiling. Isolating one or two important pieces may be a challenge, but the interviewer may be looking for the answers “class library” and “Common Language Runtime.” It’s critical to make a case for why those are the most essential features. This is an opportunity to show your skills go beyond just technical because you can also apply critical thinking.", CourseId = 1 });
            modelBuilder.Entity<Question>().HasData(new Question { Id = 4, question = "What is the difference between managed and unmanaged code?", Answer = "When developers work within an established framework, they should be aware of certain nuances, especially those between managed and unmanaged code. This question allows you to display your knowledge of working within the framework and to differentiate that knowledge from working in other coding environments.", CourseId = 1 });
            modelBuilder.Entity<Question>().HasData(new Question { Id = 5, question = "What is CLR?", Answer = "CLR stands for Common Language Runtime. It is one of the most important components of the .Net framework. It provides building blocks for many applications.", CourseId = 1 });
            modelBuilder.Entity<Question>().HasData(new Question { Id = 6, question = "What is MVC?", Answer = "MVC stands for Model View Controller. It is an architectural model for building the .Net applications.", CourseId = 1 });
            modelBuilder.Entity<Question>().HasData(new Question { Id = 7, question = "What is an EXE and a DLL?", Answer = "Exe and DLLs are Assembly executable modules.", CourseId = 1 });

            //StudentCourse
            modelBuilder.Entity<StudentCourse>().HasData(new StudentCourse { StudentId = 1, CourseId = 1 });
            modelBuilder.Entity<StudentCourse>().HasData(new StudentCourse { StudentId = 1, CourseId = 2 });
            modelBuilder.Entity<StudentCourse>().HasData(new StudentCourse { StudentId = 1, CourseId = 3 });
            modelBuilder.Entity<StudentCourse>().HasData(new StudentCourse { StudentId = 1, CourseId = 4 });
            modelBuilder.Entity<StudentCourse>().HasData(new StudentCourse { StudentId = 1, CourseId = 5 });

            modelBuilder.Entity<StudentCourse>().HasData(new StudentCourse { StudentId = 2, CourseId = 2 });
        }
    }
}
