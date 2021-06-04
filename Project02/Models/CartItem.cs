using System;
namespace Project01.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public ItemModel Item { get; set; }
        public int Quantity { get; set; }
    }
}
