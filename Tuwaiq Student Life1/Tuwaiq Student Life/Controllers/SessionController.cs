using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tuwaiq_Student_Life.Data;
using Tuwaiq_Student_Life.Models;

namespace Tuwaiq_Student_Life.Controllers
{
    
    public class SessionController : Controller
    {
        private readonly AppDBContext _db;

        public SessionController(AppDBContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var Sessions = _db.Sessions.ToList();
            var Instructors = _db.Instructors.ToList();
            ViewData["Sessions"] = Sessions;
            ViewData["Instructors"] = Instructors;
            return View();
        }

        public IActionResult Book(int instructor_id, int student_id)
        {
            SessionModel newSession = new SessionModel();
            newSession.Duration = 4;
            newSession.InstructorId = instructor_id;
            newSession.Location = "CLASS B";
            newSession.SessionTime = new DateTime(2021, 6, 5);
            _db.Sessions.Add(newSession);
            _db.SaveChanges();

            /*StudentSessionModel newStudentSession = new StudentSessionModel();
            newStudentSession.StudentId = student_id;
            newStudentSession.SessionId = 
            newSession.Students.Add(_db.Students.FirstOrDefault(a => a.Id == student_id));
           */
            var Sessions = _db.Sessions.ToList();
            var Instructors = _db.Instructors.ToList();
            ViewData["Sessions"] = Sessions;
            ViewData["Instructors"] = Instructors;
            Response.Redirect("/Session");
            return View("Index");
        }

        public IActionResult Delete(int id)
        {
            SessionModel sessionToDelete = new SessionModel();
            sessionToDelete = _db.Sessions.Find(id);
            _db.Sessions.Remove(sessionToDelete);
            _db.SaveChanges();
            //Response.Redirect("/Session/Index");
            var Sessions = _db.Sessions.ToList();
            var Instructors = _db.Instructors.ToList();
            ViewData["Sessions"] = Sessions;
            ViewData["Instructors"] = Instructors;
            Response.Redirect("/Session");
            return View("Index");
        }
    }
}
