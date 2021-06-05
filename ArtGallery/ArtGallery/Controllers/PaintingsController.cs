using ArtGallery.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.Controllers
{
    public class PaintingsController : Controller
    {
        private readonly AppDbContext _db;

        public PaintingsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Paintings = _db.Paintings.ToList();
            ViewData["Paintings"] = Paintings;
            return View();
          
        }
        public ActionResult Details(int? artId , int pintId)
        {

            var Paintings = _db.Paintings.Where(p => p.PntId == pintId).ToList().First();
            var Artists = _db.Artists.Where(a => a.ArtId == artId).ToList().First();
            var Galleries= _db.Galleries.Where(g => g.GlrId == pintId).ToList().First();

          

            ViewData["Paintings"] = Paintings;

            ViewData["Artists"] = Artists;

            ViewData["Galleries"] = Galleries;
            return View();

        }
    }
}
