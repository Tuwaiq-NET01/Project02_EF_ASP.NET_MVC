using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterSimplified.Models
{
    public class LikeModel
    {
        public int Id { get; set; }

        //one tweet has many likes
        public UserModel User { get; set; }
        public int UserId { get; set; }
        public TweetModel Tweet { get; set; }
        public int TweetId { get; set; }





    }
}
