using Company.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Controllers
{
    public class ApiController : Controller
    {
        private readonly AppDbContext _db;
        public ApiController(AppDbContext context)
        {
            _db = context;
        }

        public IActionResult Branches()
        {
            var _Branches = _db.Branches.ToList();

            return Json(_Branches);
        }
        public IActionResult Departments()
        {
            var _Departments = _db.Departments.ToList();

            return Json(_Departments);
        }
        public IActionResult Employees()
        {
            var _Employees = _db.Employees.ToList();

            return Json(_Employees);
        }
        public IActionResult Managers()
        {
            var _Managers = _db.Managers.ToList();

            return Json(_Managers);
        }
    }
}
