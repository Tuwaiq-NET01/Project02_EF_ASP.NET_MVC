using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project02_EF_MVC.Models
{
    public class Course
    {

        public int Id { get; set; }
        public string Title { get; set; }


        public ICollection<Teacher> Teachers { get; set; }
        //public ICollection<Student> Students { get; set; }

        public ICollection<StudentsCourses> StudentsCourses { get; set; }

    }
}
