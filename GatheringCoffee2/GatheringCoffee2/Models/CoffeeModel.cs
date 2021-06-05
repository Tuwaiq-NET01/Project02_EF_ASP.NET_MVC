using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringCoffee2.Models
{
    public class CoffeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }

        // navication propetis : on-to-many: Customer---<- Coffee

        public OrderModel? Order { get; set; }
        // FK
        
        public int? OrderId { get; set; }

        // navication propetis
        public CoffeeCategoryModel CoffeeCategory { get; set; }
        //FK
        public int CoffeeCategoryId { get; set; }


    }
}
