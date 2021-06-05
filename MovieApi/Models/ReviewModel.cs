using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models
{
    public class ReviewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public float Rating { get; set; }
        [Required]
        public string Comment { get; set; }
        
        // Relationship Movie - Reviews
        public MovieModel Movie { get; set; }
        public int MovieId { get; set; }
        
        // Relationship Users - Reviews
        public UserModel User { get; set; }
        public int UserId { get; set; }
        
        
    }
}