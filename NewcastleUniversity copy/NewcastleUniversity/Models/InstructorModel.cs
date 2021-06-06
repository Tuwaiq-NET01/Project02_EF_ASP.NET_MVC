using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewcastleUniversity.Models
{
    public class InstructorModel
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public string PhoneNum { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string password { get; set; }

        //navagation properties table StudentToInstructors Instructors Many-to-Many
        public List<StudentToInstructor> StudentsToInstructors { get; set; }
    }
}
