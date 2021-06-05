using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BooksStoreMVC.Data;
namespace BooksStoreMVC.Models

{

    public class PublisherModel
    {
        [Key]
        [Required]
        public int PubId { get; set; }
        public string PubPhone { get; set; }
        public string PubName { get; set; }

        //Relationship : One-To-Many: Publisher => Books
        public List<BookModel> Book { get; set; }

    }
}
