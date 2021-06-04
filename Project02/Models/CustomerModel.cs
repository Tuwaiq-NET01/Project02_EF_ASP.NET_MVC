using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage = "User Name Is Required")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password Is Required")]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
         
        //Relationship with items
        public List<ItemModel> Items { get; set; }

        //Relactionship with cart
        public CartModel Cart { get; set; }

        //Relationship with order
        public List<OrderModel> Orders { get; set; }

    }
}
