using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewcastleUniversity.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        //navagation Students one to many (department has many student -> student belngs to one department)
        public List<StudentModel> Student { get; set; }
    }
}
