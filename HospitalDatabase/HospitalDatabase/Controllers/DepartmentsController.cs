using HospitalDatabase.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDatabase.Controllers
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
            var Departments = _db.Departments.ToList();
            ViewData["Departments"] = Departments;
            return View();
        }
    }
}
