using System.Dynamic;

namespace BookStore.Models
{
    public class BookAuthorsModel
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public BookModel Book { get; set; }
        public int AuthorId { get; set; }
        public AuthorModel Author { get; set; }
    }
}