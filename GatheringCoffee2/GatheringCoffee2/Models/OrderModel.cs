using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringCoffee2.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        // navication propetis
        public CustomerModel Customer { get; set; }
        //FK
        public int CustomerId { get; set; }

        // navication propetis : on-to-many: Order---<- Coffee

        public List<CoffeeModel> Coffee { get; set; }

        // navication propetis : on-to-many: Order---<- SweetAndFood

        public List<SweetAndFoodModel> SweetAndFood { get; set; }
    }
}
