using HospitalDatabase.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDatabase.Controllers
{
    public class MedicationsPatientsController : Controller
    {
        private readonly AppDbContext _db;
        public MedicationsPatientsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var MedicationsPatients = _db.Medications_Patients.ToList();
            ViewData["MedicationsPatients"] = MedicationsPatients;
            return View();
        }
    }
}
