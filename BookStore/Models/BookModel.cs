using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Rating { get; set; }
        
        public int PublisherId { set; get; }
        public PublisherModel Publisher { get; set; }
        
        public int CategoryId { set; get; }
        public CategoryModel Category { get; set; }
        
        public List<BookAuthorsModel> Authors { get; set; }
    }
}