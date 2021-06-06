using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewcastleUniversity.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        [Required]
        public string password { get; set; }

        //navagation properties table StudentToCourses Courses Many-to-Many 
        public List<StudentToCourse> StudentsToCourses { get; set; }


        //navagation properties table StudentToInstructors Instructors Many-to-Many
        public List<StudentToInstructor> StudentsToInstructors { get; set; }

        //navagation properties table Departmant One(Department)to Many(Student) FK here
        public int departmentId { get; set; }
        public DepartmentModel department { get; set; }



        ////FOR TESTING
        public RoomModel Room { get; set; }
    }
}
