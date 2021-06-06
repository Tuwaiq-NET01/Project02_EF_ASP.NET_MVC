using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDatabase.Models
{
    public class PatientModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }


        public List<Doctor_Patient_Model> Doctor_Patient { get; set; }
        public List<Medication_Patient_Model> Medication_Patient { get; set; }

    }
}
