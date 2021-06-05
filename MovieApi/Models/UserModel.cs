using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string ProfilePic { get; set; }
    }
}