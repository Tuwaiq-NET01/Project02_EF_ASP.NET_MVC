using HospitalDatabase.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDatabase.Controllers
{
    public class DoctorsPatientsController : Controller
    {
        private readonly AppDbContext _db;
        public DoctorsPatientsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var DoctorsPatients = _db.Doctors_Patients.ToList();
            ViewData["DoctorsPatients"] = DoctorsPatients;
            return View();
        }
    }
}
