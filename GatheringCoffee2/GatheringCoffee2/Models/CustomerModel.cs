using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringCoffee2.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        // navication propetis
        public OrderModel Order { get; set; }

       
    }
}
