using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class PhysicianModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }
        [Column(TypeName = "varchar(200)")]
        public char gender { get; set; }

        public List<DepartmentModel> Departments { get; set; }
        public List<AppointmentModel> appointments { get; set; }
    }
}
