using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace TuwaiqDatabase.Models
{
    public class Bootcamp
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}