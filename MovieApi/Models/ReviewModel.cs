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
    }
}