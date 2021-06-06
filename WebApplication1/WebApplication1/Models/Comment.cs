using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Comment
    {     
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string comment;

        // one to many relation with place entity 
      public int placeId { get; set; }
       public Place place { get; set; }

    }
}
