using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BooksStoreMVC.Data;
namespace BooksStoreMVC.Models

{

    public class BookModel
    {
        [Key]
        [Required]
        public int ISBN { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        //Relationship : One-To-Many: Publisher => Books
        public PublisherModel Publisher { get; set; }

        //FK
        public int PubId { get; set; }

        // Many to Many Books <=> Authers
        public List<WrittenByAuthorsBooks> WrittenByAuthorsBooks { get; set; }



    }
}
