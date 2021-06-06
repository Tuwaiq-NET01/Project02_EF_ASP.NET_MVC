using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameOnTheHouse.Data;
using Microsoft.AspNetCore.Mvc;


namespace GameOnTheHouse.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _db;

        public UserController(AppDbContext context)
        {
            _db = context;
        }


        // GET: /<controller>/
        public IActionResult Index(string color="black")
        {
            string img = "https://www.freeiconspng.com/uploads/controller-game-icon-10.png";
            ViewData["img"] = img;
            ViewData["color"] = color;
            return View();
        }
    }
}
