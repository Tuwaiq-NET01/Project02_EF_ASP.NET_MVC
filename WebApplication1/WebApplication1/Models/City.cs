using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class City
    {
        [Key]
        public int cityId { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(400)")]
        public string description { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string Population { get; set; }

        public List<Place> places { get; set; }


    }
}
