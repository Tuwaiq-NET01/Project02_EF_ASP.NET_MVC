using System.Text.Json.Serialization;

namespace MovieApi.Models
{
    public class GenreMovieModel
    {
        public int Id { get; set; }
        [JsonIgnore]
        public GenreModel Genre { get; set; }
        public int GenreId { get; set; }

        [JsonIgnore]
        public MovieModel Movie { get; set; }
        public int MovieId { get; set; }
    }
}