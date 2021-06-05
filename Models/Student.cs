using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TuwaiqDatabase.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("Bootcamp")]
        public int Bootcamp { get; set; }

    }
}