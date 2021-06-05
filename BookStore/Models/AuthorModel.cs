using System.Collections.Generic;

namespace BookStore.Models
{
    public class AuthorModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }

        public List<BookAuthorsModel> Books { get; set; }
    }
}