using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDatabase.Models
{
    public class Medication_Patient_Model
    {
        public int Id { get; set; }

        public int PatientId { get; set; }
        public PatientModel Patient { get; set; }

        public int MedicationId { get; set; }
        public MedicationModel Medication { get; set; }
    }
}
