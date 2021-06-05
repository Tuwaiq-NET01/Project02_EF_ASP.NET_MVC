using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tuwaiq_Student_Life.Models
{
    public class SessionModel
    {
        public int Id { set; get; }

        [DataType(DataType.Date)]
        public DateTime SessionTime { set; get; }

        public InstructorModel Instructor { set; get; }
        public int InstructorId { set; get; }

        public ICollection<StudentModel> Students { set; get; }

    }
}
