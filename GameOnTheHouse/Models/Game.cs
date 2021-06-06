using System;
using System.Collections.Generic;

namespace GameOnTheHouse.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string ShortDcrp { get; set; }
        public string GameUrl { get; set; }

        public GameDetail GameDetail { get; set; }

        public ICollection<FavoriteGame> FavoriteGames { get; set; }
    }
}
