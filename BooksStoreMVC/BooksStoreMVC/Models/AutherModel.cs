
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BooksStoreMVC.Data;
namespace BooksStoreMVC.Models

{

    public class AutherModel
    {
        [Key]
        [Required]
        public int AuthId { get; set; }
        public string AuthPhone { get; set; }
        public string AuthName { get; set; }

        // Many to Many Books <=> Authers
        public List<WrittenByAuthorsBooks> WrittenByAuthorsBooks { get; set; }


    }
}
