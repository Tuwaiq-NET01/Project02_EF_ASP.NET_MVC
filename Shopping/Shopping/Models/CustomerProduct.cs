using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class CustomerProduct
    {

        public int CustomerID { get; set; }
        public CustomerModel Customer { get; set; }

        public int ProductID { get; set; }
        public ProductModel Product { get; set; }
        
    }
}
