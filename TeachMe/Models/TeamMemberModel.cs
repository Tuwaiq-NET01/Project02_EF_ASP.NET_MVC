using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TeachMe.Models
{
    public class TeamMemberModel
    {
        public int Member_ID { get; set; }
        public string Member_Name { get; set; }
        public string Member_Image { get; set; }
        public string About_Member { get; set; }
        public TeamMemberModel()
        {
            this.Member_ID=0;
            this.Member_Name="";
            this.Member_Image="";
            this.About_Member="";
        
        }
        public TeamMemberModel(int Member_ID, string Member_Name, string Member_Image, string About_Member)
        {
            this.Member_ID = Member_ID;
            this.Member_Name = Member_Name;
            this.Member_Image = Member_Image;
            this.About_Member = About_Member;
        }
    }
}

