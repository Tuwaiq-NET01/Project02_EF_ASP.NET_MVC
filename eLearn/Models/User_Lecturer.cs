using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLearn.Models
{
    public class User_Lecturer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }

    }
}
