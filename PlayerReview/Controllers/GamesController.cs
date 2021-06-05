using Microsoft.AspNetCore.Mvc;
using PlayerReview.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerReview.Controllers
{
    public class GamesController : Controller
    {

        private readonly AppDbContext _db; 
        public GamesController(AppDbContext context)
        { 
            _db = context; 
        }



        public IActionResult Index()
        {
            var games = _db.Games.ToList();
            var companies = _db.Companies.ToList();
            ViewData["games"] = games;
            ViewData["companies"] = companies;
            return View();
        }


        public IActionResult Details(int id)
        {
            ViewData["game"] = _db.Games.ToList().Find(g => g.Id == id);
            var companies = _db.Companies.ToList();
            ViewData["companies"] = companies;
            var users= _db.Users.ToList();
            ViewData["users"] = users;

            var reviews = _db.Reviews.Where(r => r.GameId == id).ToList();
            ViewData["reviews"] = reviews;


            if (ViewData["game"] == null)
            {
                //return Content("not found");
                return View("fof");
            }

            return View();
        }

        public IActionResult Search(string txt)
        {

            var target = txt;
            var searchRes = _db.Games.Where(a => a.GameName.Contains(target)).ToList();
            ViewData["target"] = target;
            ViewData["searchRes"] = searchRes;
            return View();

        }


    }
}
