namespace MovieApi.Models
{
    public class GenreMovieModel
    {
        public int Id { get; set; }

        public GenreModel Genre { get; set; }
        public int GenreId { get; set; }

        public MoiveModel Movie { get; set; }
        public int MovieId { get; set; }
    }
}