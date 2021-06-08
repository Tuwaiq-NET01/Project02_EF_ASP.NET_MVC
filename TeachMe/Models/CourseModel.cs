using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeachMe.Models
{
    public class CourseModel
    {
        public int Course_ID { get; set; }
        public string Course_Name { get; set; }
        public string Course_Category { get; set; }
        public string Course_Description { get; set; }
        public string Course_Image { get; set; }
        public DateTime Cours_Start_Date { get; set; }
        public DateTime Coures_End_Date { get; set; }

        public CourseModel()
        {
            this.Course_ID = 0;
            this.Course_Name = "";
            this.Course_Category = "";
            this.Course_Image = "";
            this.Course_Description = "";
            this.Cours_Start_Date = new DateTime(2008, 5, 1, 8, 30, 52);
            this.Coures_End_Date = new DateTime(2008, 5, 1, 8, 30, 52);



        }
        public CourseModel(int Coures_ID, string Course_Name,string Course_Category, string Course_Image, string Course_Description, DateTime Course_Start_Date, DateTime Course_End_Date)

        {
            this.Course_ID = Coures_ID;
            this.Course_Name = Course_Name;
            this.Course_Category = Course_Category;
            this.Course_Image = Course_Image;
            this.Course_Description = Course_Description;
            this.Cours_Start_Date = Course_Start_Date;
            this.Coures_End_Date = Course_End_Date;


        }
    }
}
