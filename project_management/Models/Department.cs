using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace project_management.Models
{
    public class Departement{
        private static long auto_id = 1;
        public Departement() => Id = auto_id++;
        [Key]
        public long Id {get; set;}
        [Required]
        public string Name {get; set;}
        List<Employee> Employees {get; set;}
        
    }
}