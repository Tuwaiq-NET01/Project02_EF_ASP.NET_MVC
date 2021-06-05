using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class DepartmentModel
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        // Head Manager of the department
        public int PhysicianId { get; set; }
        public PhysicianModel Physician { get; set; }
    }
}
