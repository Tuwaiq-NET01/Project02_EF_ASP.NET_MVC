using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BranchModel Branch { get; set; }
        public int BranchId { get; set; }
        public List<EmployeeModel> Employees { get; set; }
    }
}
