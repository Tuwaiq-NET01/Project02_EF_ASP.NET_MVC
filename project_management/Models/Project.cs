using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace project_management.Models
{
    public class Project{
        private static long auto_id = 1;
        public Project() => Id = auto_id++;
        [Key]
        public long Id {get; set;}
        [Required]
        public string Name {get; set;}  
        public long ProjectMgrId {get; set;}
        [ForeignKey("ProjectMgrId")]
        public Employee Employee {get; set;}
        public long DepId {get; set;}
        [ForeignKey("DepId")]
        public Departement Departement {get; set;}
        [Required]
        [DataType(DataType.Text)]
        public string Description {get; set;}


    }
}