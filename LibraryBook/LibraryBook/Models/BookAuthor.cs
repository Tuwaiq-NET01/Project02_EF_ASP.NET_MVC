using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBook.Models
{
    public class BookAuthor
    {
        [Key]
        public int BAId { get; set; }
        public int BookID { get; set; }
        public BookModel BookModel { get; set; }
        public int AuthorID { get; set; }
        public AuthorModel AuthorModel { get; set; }
    }
}
