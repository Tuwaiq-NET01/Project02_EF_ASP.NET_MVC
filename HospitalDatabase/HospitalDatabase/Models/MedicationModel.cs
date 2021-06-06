using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDatabase.Models
{
    public class MedicationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }


        public List<Medication_Patient_Model> Medication_Patient { get; set; }

    }
}
