using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace TwitterSimplified.Models
{
    public class TweetModel
    {
        public int Id { get; set; }
        public string Content { get; set; }

        // one-to-many with user
        public UserModel User { get; set; }
        
       // public UserModel UserId { get; set; }

        //one-to-many
        public List<LikeModel> Likes { get; set; }

    }
}
