using HospitalDatabase.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDatabase.Controllers
{
    public class PatientsController : Controller
    {
        private readonly AppDbContext _db;
        public PatientsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Patients = _db.Patients.ToList();
            ViewData["Patients"] = Patients;
            return View();
        }
    }
}
