using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringCoffee2.Models
{
    public class SweetAndFoodModel
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }

        // navication propetis : on-to-many: Order---<- SweetAndFood

        public OrderModel? Order { get; set; }

        public int? OrderId { get; set; }

        // navication propetis
        public SweetAndFoodCategoryModel SweetAndFoodCategory { get; set; }
        //FK
        public int SweetAndFoodCategoryId { get; set; }
    }
}
