using eLearn.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLearn.Controllers
{
    public class LecturersController : Controller
    {
        private readonly AppDbContext _db;
        public LecturersController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Lecturers = _db.Lecturer.ToList();
            ViewData["Lecturers"] = Lecturers;
            return View();
        }
    }
}
