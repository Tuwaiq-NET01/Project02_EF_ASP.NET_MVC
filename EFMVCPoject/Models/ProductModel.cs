using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFMVCPoject.Models
{
    public class ProductModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        //navication property
        public OrderLineModel OrderLine { get; set; }
        public int OrderLineID { get; set; }
    }
}
