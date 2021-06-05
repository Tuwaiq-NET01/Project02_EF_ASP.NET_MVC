using System;
namespace Project02_EF_ASP.NET_MVC.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string color { get; set; }

        public CustomerModel Customer { get; set; }

        public StoreModel? Store { get; set; }
        public int? StoreId { get; set; }

        public CategoryModel? Category { get; set; }
        public int? CategoryID { get; set; }
    }
}
