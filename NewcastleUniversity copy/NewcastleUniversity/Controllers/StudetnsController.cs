using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewcastleUniversity.Data;
using NewcastleUniversity.Models;

namespace NewcastleUniversity.Controllers
{
    public class StudetnsController : Controller
    {
        private readonly AppDbContext _db;

        public StudetnsController (AppDbContext context)
        {
            _db = context;
        }


        public IActionResult Index()
        {
            var Students = _db.Students.ToList();
            ViewData["Students"] = Students;
            return View();
        }

        public IActionResult Details(int id)
        {
            var Student = _db.Students.ToList().Find(s => s.Id == id);
            if(Student == null)
            {
                return Content("ERROR");
            }
            else
            {
                ViewData["Student"]= Student;
            }

            return View();

        }


        public IActionResult InstructorIndex()
        {
            var instructor = _db.Instructors.ToList();
            ViewData["instructor"] = instructor;
            return View();
        }

        public IActionResult InstructorDetails(int id)
        {
            var instructor = _db.Instructors.ToList().Find(s => s.Id == id);
            if (instructor == null)
            {
                return Content("ERROR");
            }
            else
            {
                ViewData["instructor"] = instructor;
            }

            return View();

        }

    }
}
