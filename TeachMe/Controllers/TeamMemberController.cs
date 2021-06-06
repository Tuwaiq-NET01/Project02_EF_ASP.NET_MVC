using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachMe.Models;

namespace TeachMe.Controllers
{
    public class TeamMemberController : Controller
    {
        List<TeamMemberModel> _TeamMember = new List<TeamMemberModel>()
        {

         new TeamMemberModel { Member_ID = 1, Member_Name ="Ahmad", Member_Image ="https://images.pexels.com/photos/4064839/pexels-photo-4064839.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",About_Member="BS Information System"},
         new TeamMemberModel { Member_ID = 2, Member_Name ="Sara", Member_Image ="https://images.pexels.com/photos/1181673/pexels-photo-1181673.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",About_Member="BS Computer Science"},
         new TeamMemberModel { Member_ID = 3, Member_Name ="Ali", Member_Image ="https://images.pexels.com/photos/5496467/pexels-photo-5496467.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",About_Member=" BS Software Engeineer"},
         new TeamMemberModel { Member_ID = 4, Member_Name ="Amal", Member_Image ="https://images.pexels.com/photos/3987114/pexels-photo-3987114.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",About_Member="BS Hardware Engenineer"},

        };
        public IActionResult Index()
        {
            ViewData["TeamMemberModel"] =_TeamMember;
            return View(_TeamMember);
        }
    }
}
