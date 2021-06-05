using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterSimplified.Controllers
{
    public class UsersHome : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
