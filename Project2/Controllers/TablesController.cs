using Microsoft.AspNetCore.Mvc;
using Project2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Controllers
{
    public class TablesController : Controller
    {
        private readonly AppDbContext appDbContext;

        public TablesController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            // characters table
            ViewData["Characters"] = appDbContext.Characters.ToList();

            // users table
            ViewData["Users"] = appDbContext.Users.ToList();

            // characters status
            ViewData["CharacterStatus"] = appDbContext.CharacterStatus.ToList();

            // users favorites
            ViewData["UserFavorites"] = appDbContext.UserFavorites.ToList();

            return View();
        }
    }
}
