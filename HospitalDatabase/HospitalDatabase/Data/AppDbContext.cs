using HospitalDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDatabase.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        
        }
        public DbSet<DoctorModel> Doctors { get; set; }
        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<MedicationModel> Medications { get; set; }
        public DbSet<Doctor_Patient_Model> Doctors_Patients { get; set; }
        public DbSet<Medication_Patient_Model> Medications_Patients { get; set; }


        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoctorModel>().HasData(new DoctorModel { Id = 1, FirstName = "Yasmin", LastName = "AlGhamdi", Department = "General Medicine", Email = "YasminG@hotmail.com", PhoneNumber="055-569-9110", DepartmentId = 20});
            modelBuilder.Entity<DoctorModel>().HasData(new DoctorModel { Id = 2, FirstName = "Rita", LastName = "Farr", Department = "Surgery ", Email = "RitaF@hotmail.com", PhoneNumber = "050-569-9110", DepartmentId = 21});
            modelBuilder.Entity<DoctorModel>().HasData(new DoctorModel { Id = 3, FirstName = "Tony", LastName = "Roberts", Department = "Psychiatry", Email = "TonyR@hotmail.com", PhoneNumber = "054-932-6548", DepartmentId = 22 });
            modelBuilder.Entity<DoctorModel>().HasData(new DoctorModel { Id = 4, FirstName = "Amelia", LastName = "Owen", Department = "General Medicine", Email = "AmeliaO@hotmail.com", PhoneNumber = "051-436-5094", DepartmentId = 20 });
            modelBuilder.Entity<DoctorModel>().HasData(new DoctorModel { Id = 5, FirstName = "Kyle", LastName = "Fox", Department = "Surgery ", Email = "KyleF@hotmail.com", PhoneNumber = "059-330-4393", DepartmentId = 21 });

            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { Id = 10, FirstName = "Alexia", LastName = "Perry", Email = "AlexiaP@hotmail.com", PhoneNumber = "055-099-4432" });
            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { Id = 11, FirstName = "Penelope", LastName = "Ray", Email = "PenelopeR@hotmail.com", PhoneNumber = "054-090-5326" });
            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { Id = 12, FirstName = "Noah", LastName = "Roberts", Email = "NoahR@hotmail.com", PhoneNumber = "053-675-4490" });
            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { Id = 13, FirstName = "Luke", LastName = "Luna", Email = "LukeL@hotmail.com", PhoneNumber = "055-546-3210" });
            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { Id = 14, FirstName = "Timothy", LastName = "Riley", Email = "TimothyR@hotmail.com", PhoneNumber = "053-556-7432" });
            modelBuilder.Entity<PatientModel>().HasData(new PatientModel { Id = 15, FirstName = "Bella", LastName = "Holt", Email = "BellaH@hotmail.com", PhoneNumber = "058-903-8953" });

            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { Id = 20, Name = "General Medicine", Location = "2nd Floor"});
            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { Id = 21, Name = "Surgery", Location = "3rd Floor"});
            modelBuilder.Entity<DepartmentModel>().HasData(new DepartmentModel { Id = 22, Name = "Psychiatry", Location = "4th Floor"});

            modelBuilder.Entity<MedicationModel>().HasData(new MedicationModel { Id = 30, Name = "Lantus Solostar", Brand = "Sanofi-Aventis" });
            modelBuilder.Entity<MedicationModel>().HasData(new MedicationModel { Id = 31, Name = "Abilify", Brand = "Otsuka" });
            modelBuilder.Entity<MedicationModel>().HasData(new MedicationModel { Id = 32, Name = "Advair Diskus", Brand = "GlaxoSmithKline" });
            modelBuilder.Entity<MedicationModel>().HasData(new MedicationModel { Id = 33, Name = "Lyrica", Brand = "Pfizer" });
            modelBuilder.Entity<MedicationModel>().HasData(new MedicationModel { Id = 34, Name = "Januvia", Brand = "Merck" });

            modelBuilder.Entity<Doctor_Patient_Model>().HasData(new Doctor_Patient_Model { Id = 40, DoctorId = 1, PatientId = 13 });
            modelBuilder.Entity<Doctor_Patient_Model>().HasData(new Doctor_Patient_Model { Id = 41, DoctorId = 4, PatientId = 11 });
            modelBuilder.Entity<Doctor_Patient_Model>().HasData(new Doctor_Patient_Model { Id = 42, DoctorId = 3, PatientId = 15 });
            modelBuilder.Entity<Doctor_Patient_Model>().HasData(new Doctor_Patient_Model { Id = 43, DoctorId = 2, PatientId = 14 });
            modelBuilder.Entity<Doctor_Patient_Model>().HasData(new Doctor_Patient_Model { Id = 44, DoctorId = 2, PatientId = 13 });
            modelBuilder.Entity<Doctor_Patient_Model>().HasData(new Doctor_Patient_Model { Id = 45, DoctorId = 4, PatientId = 10 });
            modelBuilder.Entity<Doctor_Patient_Model>().HasData(new Doctor_Patient_Model { Id = 46, DoctorId = 5, PatientId = 12 });
            modelBuilder.Entity<Doctor_Patient_Model>().HasData(new Doctor_Patient_Model { Id = 47, DoctorId = 1, PatientId = 15 });
            modelBuilder.Entity<Doctor_Patient_Model>().HasData(new Doctor_Patient_Model { Id = 48, DoctorId = 3, PatientId = 11 });

            modelBuilder.Entity<Medication_Patient_Model>().HasData(new Medication_Patient_Model { Id = 50, MedicationId = 30, PatientId = 13 });
            modelBuilder.Entity<Medication_Patient_Model>().HasData(new Medication_Patient_Model { Id = 51, MedicationId = 34, PatientId = 11 });
            modelBuilder.Entity<Medication_Patient_Model>().HasData(new Medication_Patient_Model { Id = 52, MedicationId = 31, PatientId = 15 });
            modelBuilder.Entity<Medication_Patient_Model>().HasData(new Medication_Patient_Model { Id = 53, MedicationId = 32, PatientId = 14 });
            modelBuilder.Entity<Medication_Patient_Model>().HasData(new Medication_Patient_Model { Id = 54, MedicationId = 32, PatientId = 13 });
            modelBuilder.Entity<Medication_Patient_Model>().HasData(new Medication_Patient_Model { Id = 55, MedicationId = 34, PatientId = 10 });
            modelBuilder.Entity<Medication_Patient_Model>().HasData(new Medication_Patient_Model { Id = 56, MedicationId = 33, PatientId = 12 });
            modelBuilder.Entity<Medication_Patient_Model>().HasData(new Medication_Patient_Model { Id = 57, MedicationId = 30, PatientId = 15 });
            modelBuilder.Entity<Medication_Patient_Model>().HasData(new Medication_Patient_Model { Id = 58, MedicationId = 31, PatientId = 11 });
        }
    }
}


