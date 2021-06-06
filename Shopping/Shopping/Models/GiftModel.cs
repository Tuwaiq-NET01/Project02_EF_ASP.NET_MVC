using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class GiftModel
    {
        [Required]
        public int ID { get; set; } 
        public string GiftedProduct { get; set; }
        public string Giver { get; set; }
        public string Recipient { get; set; }


        // One-to-Many Relationship
        public int CustomerID { get; set; } //FK
        public CustomerModel Customer { get; set; }
        
        
    }
}
