﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class UserFavorite
    {

        public int UserId { get; set; }
        public User User { get; set; }


        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
