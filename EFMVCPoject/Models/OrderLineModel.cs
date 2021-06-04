using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFMVCPoject.Models
{
    public class OrderLineModel
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public int Subtotal { get; set; }

        //Relationship : one-To-Many: order----has many--->orderLine
        public OrderModel Order { get;set; }
        public int OrderID { get; set; }

        //navication property

        public ProductModel Product { get; set; }
    }
}
