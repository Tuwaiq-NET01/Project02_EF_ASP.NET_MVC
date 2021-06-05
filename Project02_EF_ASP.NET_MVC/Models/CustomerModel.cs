using System;
namespace Project02_EF_ASP.NET_MVC.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public CarModel Car { get; set; }
        public int CarId { get; set; }
    }
}
