using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class AppointmentModel
    {
        public int ID { get; set; }
        public string Date_Time { get; set; }

        public int PatientId { get; set; }
        public PatientModel Patient { get; set; }

        public int PhysicianId { get; set; }
        public PhysicianModel Physician { get; set; }
    }
}
