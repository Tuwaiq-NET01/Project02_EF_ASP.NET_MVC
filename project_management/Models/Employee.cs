using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace project_management.Models
{
    public class Employee{
        private static long auto_id = 1;
        public Employee() => Id = auto_id++;
        [Key]
        public long Id {get; set;}
        [Required]
        public string FirstName {get; set;}
        [Required]
        public string LastName {get; set;}
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email {get; set;}
        public long DepId{get; set;}
        [ForeignKey("DepId")]
        public Departement Departement {get; set;}

    }
}