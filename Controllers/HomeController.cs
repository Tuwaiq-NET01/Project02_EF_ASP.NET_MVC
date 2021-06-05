using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TuwaiqDatabase.Models;
using TuwaiqDatabase.Data;

namespace TuwaiqDatabase.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Students(string search, int? ID)
        {
            if (ID != null) ViewData["students"] = from student in _db.Students where student.Id == ID select student;
            else if (search != null) ViewData["students"] = from student in _db.Students where student.Name.Contains(search) select student;
            else ViewData["students"] = from student in _db.Students select student;
            return View();
        }

        public IActionResult Instructors(string search, int? ID)
        {
            if (ID != null) ViewData["instructors"] = from instructor in _db.Instructors where instructor.Id == ID select instructor;
            else if (search != null) ViewData["instructors"] = from instructor in _db.Instructors where instructor.Name.Contains(search) select instructor;
            else ViewData["instructors"] = from instructor in _db.Instructors select instructor;
            return View();
        }

        public IActionResult Bootcamps(string search, int? ID)
        {
            if (ID != null) ViewData["bootcamps"] = from bootcamp in _db.Bootcamps where bootcamp.Id == ID select bootcamp;
            else if (search != null) ViewData["bootcamps"] = from bootcamp in _db.Bootcamps where bootcamp.Name.Contains(search) select bootcamp;
            else ViewData["bootcamps"] = from bootcamp in _db.Bootcamps select bootcamp;
            return View();
        }

        public IActionResult Classes(string search, int? ID)
        {
            if (ID != null) ViewData["classes"] = from cls in _db.Classes where cls.Id == ID select cls;
            else if (search != null) ViewData["classes"] = from cls in _db.Classes where cls.Name.Contains(search) select cls;
            else ViewData["classes"] = from cls in _db.Classes select cls;
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
