using System.Collections.Generic;

namespace BookStore.Models
{
    public class CategoryModel
    {
        public int Id { set; get; }
        public string Name { get; set; }
        
        public List<BookModel> Books { get; set; }
    }
}