using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace project_management.Models
{
    public class Task{
        private static long auto_id = 1;
        public Task() => Id = auto_id++;
        [Key]
        public long Id {get; set;}
        public long EmpId {get; set;}
        [ForeignKey("EmpId")]
        public Employee Employee {get; set;}
        public long ProjectId {get; set;}
        [ForeignKey("ProjectId")]
        public Project Project {get; set;}
        [DataType(DataType.Text)]
        public string Description {get; set;}

    }
}