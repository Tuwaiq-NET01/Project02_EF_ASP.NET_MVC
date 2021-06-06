using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewcastleUniversity.Models
{
    public class StudentToCourse
    {
        public int StudentId { get; set; }
        public StudentModel Students { get; set; }

        public int CourseId { get; set; }
        public CourseModel Courses { get; set; }
    }
}
