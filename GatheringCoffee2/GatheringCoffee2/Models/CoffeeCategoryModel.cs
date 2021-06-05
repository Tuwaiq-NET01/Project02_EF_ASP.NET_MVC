using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringCoffee2.Models
{
    public class CoffeeCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // navication propetis
        public List<CoffeeModel> Coffee { get; set; }

    }
}
