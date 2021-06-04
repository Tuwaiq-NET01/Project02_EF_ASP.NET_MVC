using EF_MVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_MVC.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly AppDbContext _db;

        public ReviewsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var DbReviews = _db.Reviews.ToList();
            ViewBag.Reviews = DbReviews;
            return View();
        }
    }
}
