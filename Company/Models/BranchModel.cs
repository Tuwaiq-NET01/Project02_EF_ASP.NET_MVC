using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Models
{
    public class BranchModel
    {
        public int Id { get; set; }
        public int NumberOfEmployees { get; set; }
        public int NumberOfManagers { get; set; }
        public int NumberOfDepartments { get; set; }
        public string Location { get; set; }
        public List<DepartmentModel> Departments { get; set; }
    }
}