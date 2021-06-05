using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterSimplified.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string Bio { get; set; }

        // one-to-one with user
        public UserModel User { get; set; }
        // user foreign key
        public int UserId { get; set; }

    }
}
