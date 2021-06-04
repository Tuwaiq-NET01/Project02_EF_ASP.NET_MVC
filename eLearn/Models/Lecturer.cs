﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eLearn.Models
{
    public class Lecturer
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<User_Lecturer> User_Lecturer { get; set; }
        public List<Lecturer_Course> Lecturer_Course { get; set; }
    }
}
