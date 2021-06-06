using HospitalDatabase.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDatabase.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly AppDbContext _db;
        public DoctorsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Doctors = _db.Doctors.ToList();
            ViewData["Doctors"] = Doctors;
            return View();
        }
    }
}
