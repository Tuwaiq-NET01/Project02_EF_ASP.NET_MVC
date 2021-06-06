using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("CharacterStatus")]
        public int StatusId { get; set; }

        //public int CharacterStatusId { get; set; }
        public CharacterStatus Status { get; set; }


        public List<UserFavorite> UserFavorites { get; set; }
    }
}
