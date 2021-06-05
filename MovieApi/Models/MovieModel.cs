using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models
{
    public class MovieModel
    {
        [Key] public int id { get; set; }
        public string backdrop_path { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }
        public string release_date { get; set; }
        public string title { get; set; }
        public double vote_average { get; set; }
        public int runtime { get; set; }
        public string imdb_id { get; set; }

        // Relationship Movie - Reviews
        public List<ReviewModel> Reviews { get; set; }

        // Movie To Genre Relationship M-M
        public List<GenreMovieModel> GenreMovie { get; set; }
        
    }
}