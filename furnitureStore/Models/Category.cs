using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace furnitureStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        public String NameOfCategory { get; set; }
        public List<Furniture> Furnitures { get; set; }
    }
}
