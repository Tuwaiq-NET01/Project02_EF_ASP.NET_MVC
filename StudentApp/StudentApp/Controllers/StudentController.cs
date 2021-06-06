using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentApp.Data;
using StudentApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentApp.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _Db;

        public StudentController(AppDbContext appDb)
        {
            this._Db = appDb;
        }
        // GET: /<controller>/
        [HttpGet]
        public List<Student>  Get()
        {
            var students = _Db.Students.ToList();
            //ViewData["students"] = students;
            //return View();
            return students;
        }
        [Route("{id:int}")]
        [HttpGet]
        public List<Course> Get(int id)
        {
            var courses = _Db.Courses.FromSqlRaw("select * from Courses where Id in (select CourseId from StudentCourse where StudentCourse.StudentId="+ id + ") ;").ToList();//.Where(c => c.Id== c.StudentCourse.Where(sc => sc.StudentId==id).)
            return courses;
        }
        [Route("{id:int}")]
        [HttpDelete]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {
            var student = await _Db.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            _Db.Students.Remove(student);
            await _Db.SaveChangesAsync();

            return student;
        }
    }
}
