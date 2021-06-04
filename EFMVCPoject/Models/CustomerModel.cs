using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFMVCPoject.Models
{
    public class CustomerModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        //navication property
        public OrderModel Order { get; set; }
        //FK
        public int OrderID { get; set; }
    }
}
