using System.Collections.Generic;

namespace BookStore.Models
{
    public class PublisherModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookModel> Books { get; set; }
    }
}