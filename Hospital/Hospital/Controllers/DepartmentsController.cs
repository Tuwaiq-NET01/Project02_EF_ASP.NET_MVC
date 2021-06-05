using Hospital.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly AppDbContext _db;

        public DepartmentsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var DbDepartments = _db.Departments.ToList();
            ViewBag.Departments = DbDepartments;
            return View();
        }
    }
}
