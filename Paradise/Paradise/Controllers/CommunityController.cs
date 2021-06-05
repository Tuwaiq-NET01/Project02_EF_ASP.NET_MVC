using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Paradise.Data;


namespace Paradise.Controllers
{
    public class CommunityController : Controller
    {
        private readonly AppDbContext _db;

        public CommunityController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
         
            var Comments = _db.Comments.ToList();
            ViewData["Comments"] = Comments;

            return View();
        }
    }
}
