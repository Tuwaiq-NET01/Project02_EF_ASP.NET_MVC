using System;
using System.Collections.Generic;

namespace Project02_EF_ASP.NET_MVC.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<CarModel> Cars { get; set; }

    }
}
