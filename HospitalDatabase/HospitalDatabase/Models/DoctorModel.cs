using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalDatabase.Models
{
    public class DoctorModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }


        public int DepartmentId { get; set; }
        public DepartmentModel Departments { get; set; }

        public List<Doctor_Patient_Model> Doctor_Patient { get; set; }


    }
}
