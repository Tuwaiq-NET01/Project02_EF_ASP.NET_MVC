using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBook.Models
{
    public class BookModel
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public int NoPage { get; set; }
        public string Notes { get; set; }

        [ForeignKey("BookStoreModel")]
        public int IdBookStore { get; set; }
        public BookStoreModel BookStoreModel { get; set; }
        public List<BookAuthor> BookAuthor { get; set; }


    }
}
