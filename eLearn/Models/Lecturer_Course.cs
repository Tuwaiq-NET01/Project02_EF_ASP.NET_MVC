using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLearn.Models
{
    public class Lecturer_Course
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
    }
}
