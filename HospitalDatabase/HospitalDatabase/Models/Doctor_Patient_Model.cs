using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDatabase.Models
{
    public class Doctor_Patient_Model
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }
        public DoctorModel Doctor { get; set; }

        public int PatientId { get; set; }
        public PatientModel Patient { get; set; }
    }
}
