using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project02_EF_MVC.Data;
using Project02_EF_MVC.Models;

namespace Project02_EF_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext context)
        {
            _db = context;

        }

        


        // GET: /<controller>/
        public IActionResult Index()
        {
            //fetch data
            var Teachers = _db.Teachers.ToList();
            ViewBag.teachers = Teachers;

            var Students = _db.Students.ToList();
            ViewBag.students = Students;

            var Courses = _db.Courses.ToList();
            ViewBag.courses = Courses;

            var StudentsCourses = _db.StudentsCourses.ToList();
            ViewBag.StudentsCourses = StudentsCourses;

            return View();
        }

        // GET: /<controller>/
        //public IActionResult ()
        //{
        //    var Teachers = _db.Teachers.ToList();
        //    ViewBag.teachers = Teachers;

        //    var Students = _db.Students.ToList();
        //    ViewBag.students = Students;

        //    var Courses = _db.Courses.ToList();
        //    ViewBag.courses = Courses;


        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
