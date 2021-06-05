using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatAdoption.Data;

namespace CatAdoption.Controllers
{
    public class AdopterController : Controller
    {
        private AppDbContext _db;
        public AdopterController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index(int id)
        {
            var cat = _db.cat.Where(c => c.id == id).ToList().First();
            var adopter = _db.adopter.Where(a => a.id == cat.AdopterId).ToList().First();
            ViewData["Adopter"] = adopter;
            return View();
        }
    }
}
