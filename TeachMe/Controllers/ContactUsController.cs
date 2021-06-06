using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachMe.Models;


namespace TeachMe.Controllers
{
    public class ContactUsController : Controller
    {
       List<ContactUsModel> _ContactUs = new List<ContactUsModel>()
        {


         new ContactUsModel { ContactUs_ID= 1, User_Name="",User_Email="",Massege_Subject="",Massege_Content=""}
         

        };
        public IActionResult Index()
        {

            ViewData["ContactUsModels"] = _ContactUs; // List NAME

            
            return View(_ContactUs);
        }
    }
}
