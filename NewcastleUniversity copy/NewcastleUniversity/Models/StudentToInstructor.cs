using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace NewcastleUniversity.Models
{
    public class StudentToInstructor
    {
        public int StudentId { get; set; }//FK
        //navagation property from student table;
        public StudentModel Students { get; set; }


        public  int InstructorId { get; set; }//FK
        public InstructorModel Instructors { get; set; }




    }
}
