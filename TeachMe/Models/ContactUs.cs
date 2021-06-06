using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachMe.Controllers;


namespace TeachMe.Models
{
    public class ContactUsModel
    {
        public int ContactUs_ID { get; set; }
        public string User_Name { get; set; }
        public string User_Email { get; set; }
        public string Massege_Subject { get; set; }
        public string Massege_Content { get; set; }

        public ContactUsModel()
        {
            this.ContactUs_ID = 0;
            this.User_Name = "";
            this.User_Email = "";
            this.Massege_Subject = "";
            this.Massege_Content = "";
        }
        public ContactUsModel(int ContactUs_ID, string User_Name, string User_Email, string Massege_Subject, string Massege_Content)
        {
            this.ContactUs_ID = ContactUs_ID;
            this.User_Name = User_Name;
            this.User_Email = User_Email;
            this.Massege_Subject = Massege_Subject;
            this.Massege_Content = Massege_Content;

        }


    }
}
