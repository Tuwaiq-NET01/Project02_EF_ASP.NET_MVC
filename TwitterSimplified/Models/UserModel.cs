using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterSimplified.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //one-to-one with profile.
        public ProfileModel Profile { get; set; }

        //one-to-many with tweets
        public List<TweetModel> Tweets { get; set; }

        //one-to-many
        public List<LikeModel> Likes { get; set; }
    }
}
