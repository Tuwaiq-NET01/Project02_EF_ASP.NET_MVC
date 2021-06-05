using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class PatientModel
    {
        public int NationalID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        [Column(TypeName = "varchar(200)")]
        public char Gender { get; set; }

        public List<AppointmentModel> Appointments { get; set; }
    }
}
