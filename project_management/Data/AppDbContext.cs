using Microsoft.EntityFrameworkCore;
using project_management.Models;
namespace project_management.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public AppDbContext(DbContextOptions options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Marketing, Finance, Operations management, Human Resource,
            modelBuilder.Entity<Departement>().HasData
            (
                new Departement { Name = "Human Resources" },
                new Departement { Name = "IT" },
                new Departement { Name = "Finance" },
                new Departement { Name = "Marketing" },
                new Departement { Name = "Operations" }
            );
            modelBuilder.Entity<Employee>().HasData
            (
                    new Employee
                    {
                        FirstName = "Mohammed",
                        LastName = "Al-Harbi",
                        Email = "Mohammed_0001@company.com",
                        DepId = 2
                    },
                    new Employee
                    {
                        FirstName = "Abdulrahman",
                        LastName = "Bin Manea",
                        Email = "Abdulrahman_0021@company.com",
                        DepId = 2
                    },
                    new Employee
                    {
                        FirstName = "Sara",
                        LastName = "Al-Qahtani",
                        Email = "Sara_0165@company.com",
                        DepId = 2
                    },
                    new Employee
                    {
                        FirstName = "Mohammed",
                        LastName = "Al-Solami",
                        Email = "Mohammed_0123@company.com",
                        DepId = 1
                    },
                    new Employee
                    {
                        FirstName = "Sultan",
                        LastName = "Al-Ghamdi",
                        Email = "Sultan_1000@company.com",
                        DepId = 3
                    },
                    new Employee
                    {
                        FirstName = "Salim",
                        LastName = "Al-Harthi",
                        Email = "Salim_0701@company.com",
                        DepId = 5
                    }
            );

            modelBuilder.Entity<Project>().HasData(
                new Project { Name = "Secret Project", ProjectMgrId = 2, DepId = 2, Description = "it's a secret" }
            );

            modelBuilder.Entity<Task>().HasData(
                new Task { EmpId = 3, ProjectId = 1, Description = "Design the system architecture"}
            );


        }


    }
}