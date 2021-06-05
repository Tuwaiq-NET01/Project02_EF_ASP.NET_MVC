using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace TuwaiqDatabase.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("Bootcamp")]
        public int BootcampId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }

    }
}