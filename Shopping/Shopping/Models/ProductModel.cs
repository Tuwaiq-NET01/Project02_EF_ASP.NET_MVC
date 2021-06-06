using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class ProductModel
    {
        [Required]
        public int id { get; set; } 
        public string name { get; set; }
        public string brand { get; set; }


        public int price { get; set; } 
        public string image { get; set; }

        public ICollection<CustomerProduct> CustomerProducts { get; set; }
    }
}
