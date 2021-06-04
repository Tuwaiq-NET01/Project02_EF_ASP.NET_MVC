using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportSystems.Models
{
    public class EmpolyeeModel
    {
        public int employee_ID { get; set; }
        public string nationality { get; set; }
        public int employee_no { get; set; }
        public string employee_name { get; set; }
        public string Gender { get; set; }
        public string blood_type { get; set; }
        public string job_title { get; set; }
        public double salary { get; set; }
        public string email { get; set; }
        public int working_hours { get; set; }
    }
}
