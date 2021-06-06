using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace NewcastleUniversity.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string CodeNum { get; set; }

        public double Fee { get; set; }

        //navagation property MANY-TO-MANY students and courses
        public List<StudentToCourse> StudentsToCourses { get; set; }
    }

    
}
