using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models
{
    public class GenreModel
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        
        // Movie To Genre Relationship M-M
        public List<GenreMovieModel> GenreMovie { get; set; }
    }
}