using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Company.Models;
namespace Company.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<BranchModel> Branches { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<ManagerModel> Managers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 1, NumberOfEmployees = 156, NumberOfManagers = 9, Location = "Riyadh", NumberOfDepartments = 9 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 2, NumberOfEmployees = 77, NumberOfManagers = 7, Location = "Jeddah", NumberOfDepartments = 7 });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { Id = 3, NumberOfEmployees = 51, NumberOfManagers = 4, Location = "Dammam", NumberOfDepartments = 4 });

            /**********/

            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { Id = 1, Name = "IT", BranchId = 1 });
            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { Id = 2, Name = "Sales", BranchId = 1 });

            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { Id = 3, Name = "Oprations", BranchId = 2 });
            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { Id = 4, Name = "HR", BranchId = 2 });

            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { Id = 5, Name = "Content", BranchId = 3 });
            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { Id = 6, Name = "Development", BranchId = 3 });

            /**********/

            modelBuilder.Entity<ManagerModel>().HasData(new ManagerModel { Id = 1, Name = "Saud", Age = 44, Gender = true, DepartmentId = 1 });
            modelBuilder.Entity<ManagerModel>().HasData(new ManagerModel { Id = 2, Name = "Sara", Age = 38, Gender = false, DepartmentId = 2 });

            modelBuilder.Entity<ManagerModel>().HasData(new ManagerModel { Id = 3, Name = "Saad", Age = 51, Gender = true, DepartmentId = 3 });
            modelBuilder.Entity<ManagerModel>().HasData(new ManagerModel { Id = 4, Name = "Sami", Age = 33, Gender = true, DepartmentId = 4 });

            modelBuilder.Entity<ManagerModel>().HasData(new ManagerModel { Id = 5, Name = "Samirah", Age = 29, Gender = false, DepartmentId = 5 });
            modelBuilder.Entity<ManagerModel>().HasData(new ManagerModel { Id = 6, Name = "Salem", Age = 62, Gender = true, DepartmentId = 6 });

            /**********/

            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel { Id = 1, Name = "Khaled", Age = 22, Gender = true, DepartmentId = 1 });
            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel { Id = 2, Name = "Ahmed", Age = 27, Gender = true, DepartmentId = 1 });

            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel { Id = 3, Name = "Amal", Age = 23, Gender = false, DepartmentId = 2 });
            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel { Id = 4, Name = "Ghada", Age = 22, Gender = false, DepartmentId = 2 });

            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel { Id = 5, Name = "Mohammed", Age = 30, Gender = true, DepartmentId = 3 });
            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel { Id = 6, Name = "Fahad", Age = 24, Gender = true, DepartmentId = 3 });

            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel { Id = 7, Name = "Nora", Age = 25, Gender = false, DepartmentId = 4 });
            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel { Id = 8, Name = "Rahaf", Age = 31, Gender = false, DepartmentId = 4 });

            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel { Id = 9, Name = "Husaain", Age = 29, Gender = true, DepartmentId = 5 });
            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel { Id = 10, Name = "Thamer", Age = 27, Gender = true, DepartmentId = 5 });

            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel { Id = 11, Name = "Tala", Age = 23, Gender = false, DepartmentId = 6 });
            modelBuilder.Entity<EmployeeModel>().HasData(new EmployeeModel { Id = 12, Name = "Lena", Age = 22, Gender = false, DepartmentId = 6 });

        }
    }
}
