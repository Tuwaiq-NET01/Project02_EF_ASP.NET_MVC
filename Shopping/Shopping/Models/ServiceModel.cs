using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class ServiceModel
    {
        [Required]
        public int ID { get; set; } 
        public string ServiceName { get; set; }

        
        public int Price { get; set; }
    }
}
