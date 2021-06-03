using System;
using System.Collections.Generic;

namespace Project02_EF_MVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //relations
        public ICollection<StudentsCourses> StudentsCourses { get; set; }

    }
}