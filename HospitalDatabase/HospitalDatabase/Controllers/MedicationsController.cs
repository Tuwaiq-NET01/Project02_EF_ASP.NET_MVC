using HospitalDatabase.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDatabase.Controllers
{
    public class MedicationsController : Controller
    {
        private readonly AppDbContext _db;
        public MedicationsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Medications = _db.Medications.ToList();
            ViewData["Medications"] = Medications;
            return View();
        }
    }
}
