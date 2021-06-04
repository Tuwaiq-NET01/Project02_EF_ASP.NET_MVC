using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.Models
{
    public class CartModel
    {
        public int Id { get; set; }
        public ItemModel Item { get; set; }
        public int Quantity { get; set; }

        //relationship with customer
        public int CustomerId { get; set; }
        public CustomerModel Customer { get; set; }

        //Relationship with items
        public List<ItemModel> Items { get; set; }

    }
}
