using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachMe.Models;


namespace TeachMe.Controllers
{
    public class CourseController : Controller
    {
        


        List<CourseModel> _Course = new List<CourseModel>()
        {


         new CourseModel { Course_ID = 1,Course_Category="",Course_Name =" Into HardWare", Course_Image ="https://images.unsplash.com/photo-1580691746056-4badd831b86e?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTB8fGNvbXB1dGVyJTIwc2NpZW5jZXxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Course_Description="In this course we will Talk About Hardware"},
         new CourseModel { Course_ID = 2,Course_Category="" ,Course_Name ="What Is Computer Science", Course_Image ="https://images.unsplash.com/photo-1610018556010-6a11691bc905?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fGNvbXB1dGVyJTIwc2NpZW5jZXxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60" , Course_Description="In this course we will Talk About Computer Sceince"},
         new CourseModel { Course_ID = 3,Course_Category="", Course_Name ="Intro Programming", Course_Image ="https://images.unsplash.com/photo-1557804506-669a67965ba0?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTd8fGFuYWx5c2lzfGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Course_Description=" In this course we wiii stude About Programming" },
         new CourseModel { Course_ID = 4, Course_Category="",Course_Name ="Data Analysis And Design", Course_Image ="https://images.unsplash.com/photo-1460925895917-afdab827c52f?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fGRhdGF8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Course_Description="In this Coures We Will Stude About Data Analysis And Design " },

        };
        public IActionResult Index()
        {
            ViewData["CourseModels"] = _Course; // List NAME


            return View(_Course);
        }
      
    }
}
