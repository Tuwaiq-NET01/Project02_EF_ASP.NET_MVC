using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using project_management.Models;
using project_management.Data;

namespace project_management.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show()
        {
            var deps = _db.Departements.ToList();
            var emps = _db.Employees.ToList();
            var projects = _db.Projects.ToList();
            var tasks = _db.Tasks.ToList();
            ViewBag.deps = deps;
            ViewBag.emps = emps;
            ViewBag.projects = projects;
            ViewBag.tasks = tasks;
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
