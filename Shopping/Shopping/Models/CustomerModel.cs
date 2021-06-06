using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class CustomerModel
    {
        [Required]
        public int ID { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; }

        public ICollection<GiftModel> Gifts { get; set; }

        public ICollection<CustomerProduct> CustomerProducts { get; set; }
    }
}
