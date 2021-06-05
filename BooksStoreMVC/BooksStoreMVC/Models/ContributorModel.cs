using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BooksStoreMVC.Data;
namespace BooksStoreMVC.Models

{

    public class ContributorModel
    {
        [Key]
        [Required]
        public int ConID { get; set; }
        public string ConName { get; set; }
        public string ConPhone { get; set; }

     
    }
}
