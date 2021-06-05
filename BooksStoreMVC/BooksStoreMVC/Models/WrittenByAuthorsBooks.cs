
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BooksStoreMVC.Data;
namespace BooksStoreMVC.Models
{
    public class WrittenByAuthorsBooks
    {
        public int AutherId { get; set; }
        public AutherModel Auther { get; set; }
        public int BookISBN { get; set; }
        public BookModel Book { get; set; }
    }
}

   
