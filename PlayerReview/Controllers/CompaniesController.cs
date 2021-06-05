using Microsoft.AspNetCore.Mvc;
using PlayerReview.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerReview.Controllers
{
    public class CompaniesController : Controller
    {

        private readonly AppDbContext _db;
        public CompaniesController(AppDbContext context)
        {
            _db = context;
        }



        public IActionResult Index()
        {
            var companies = _db.Companies.ToList();
            ViewData["companies"] = companies;

            return View();
        }

        public IActionResult Details(int id)
        {
            var company = _db.Companies.ToList().Find(g => g.Id == id);
            ViewData["company"] = company;
            if (ViewData["company"] == null)
            {
                return View("fof");
            }
            return View();
        }


    }
}
