using System;
using System.Collections.Generic;

namespace Project02_EF_MVC.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        //relatins
        public int CourseId { get; set; }
        public Course Course { get; set; }
        //public ICollection<Student> Students { get; set; }
    }
}
