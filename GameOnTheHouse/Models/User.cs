using System;
using System.Collections.Generic;

namespace GameOnTheHouse.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string ImageColor { get; set; }

        public UserAccount UserAccount { get; set; }

        public ICollection<FavoriteGame> FavoriteGames { get; set; }

    }
}
