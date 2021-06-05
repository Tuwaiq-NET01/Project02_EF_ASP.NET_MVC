using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace TuwaiqDatabase.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Expertise { get; set; }

        public DateTime JoinDate { get; set; }

        [ForeignKey("Class")]
        public int ClassId { get; set; }


    }
}