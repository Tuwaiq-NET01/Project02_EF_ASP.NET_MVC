using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFMVCPoject.Models
{
    public class OrderModel
    {
        public int ID { get; set; }
        public int Total { get; set; }

        //navication property
        public CustomerModel Customer { get; set; }

        //Relationship : one-To-Many: order----has many--->orderLine
        public List<OrderLineModel> OrderLines { get; set; }

    }
}
