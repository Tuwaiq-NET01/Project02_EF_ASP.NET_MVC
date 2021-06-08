using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeachMe.Models
{
    public class CategoryModel
    {
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
        public string Category_Image { get; set; }
        public string Category_Description { get; set; }
        public CategoryModel()
        {
            this.Category_ID = 0;
            this.Category_Name = "";
            this.Category_Image = "";
            this.Category_Description = "";
        }
        public CategoryModel(int Category_ID, string Category_Name, string Category_Image, string Category_Description)
        {
            this.Category_ID = Category_ID;
            this.Category_Name = Category_Name;
            this.Category_Image = Category_Image;
            this.Category_Description = Category_Description;
        }
    }
}
