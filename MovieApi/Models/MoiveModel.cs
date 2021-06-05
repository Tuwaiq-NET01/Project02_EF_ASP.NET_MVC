using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models
{
    public class MoiveModel
    {
        [Key]
        public int id { get; set; }
        public string backdrop_path { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }
        public string release_date { get; set; }
        public string title { get; set; }
        public double vote_average { get; set; }
        public int runtime { get; set; }
        public string imdb_id { get; set; }
        public int budget { get; set; }
        public int revenue { get; set; }
        
        // Relationship Movie - Reviews
        public List<ReviewModel> Reviews { get; set; }
    }
}