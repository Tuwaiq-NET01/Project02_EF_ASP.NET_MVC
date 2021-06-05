using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtShowMVC.Data;
using ArtShowMVC.Models;

namespace ArtShowMVC.Controllers
{
    public class ArtworksController : Controller
    {
        private readonly AppDbContext _db;

        public ArtworksController(AppDbContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            var ArtWorks = _db.ArtWorks.ToList();

            ViewData["ArtWorks"] = ArtWorks;
            
            return View();
        }
        public IActionResult Details(int id)
        {    var Artists = _db.Artsits.ToList();
            var ArtWorks = _db.ArtWorks.ToList();
            ArtWorksModel artWork = ArtWorks.Find(artWork => artWork.Id == id);

            if (artWork == null)
            {
                return Content("Not found Art works");

            }
            else {

                ViewData["ArtWorks"] = artWork;
                ViewData["Artists"] = Artists;
                return View();
            } }
    }
}
