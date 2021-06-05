using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project02_EF_ASP.NET_MVC.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project02_EF_ASP.NET_MVC.Controllers
{
    public class StoresController : Controller
    {

        private readonly AppDbContext _db;

        public StoresController(AppDbContext context)
        {
            _db = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var stores = _db.Store.ToList();
            ViewBag.Data = stores;
            return View();
        }
    }
}
