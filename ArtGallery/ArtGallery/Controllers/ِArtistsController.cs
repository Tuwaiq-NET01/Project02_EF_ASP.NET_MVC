using ArtGallery.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly AppDbContext _db;

        public ArtistsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Artists = _db.Artists.ToList();
            ViewData["Artists"] = Artists;
            return View();
        }

        public ActionResult Details(int? Id)
        {

            var Artists = _db.Artists.Where(a => a.ArtId == Id).ToList().First();
           var Paintings = _db.Paintings.Where(p => p.ArtistId == Id).ToList();
         
            ViewData["Artists"] = Artists;
            ViewData["Paintings"] = Paintings;
         
            return View();

        }

    }
}
