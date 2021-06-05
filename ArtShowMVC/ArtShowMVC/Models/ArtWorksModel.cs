using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShowMVC.Models
{
    public class ArtWorksModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }

        //rel
        public int ArtsitId { get; set; }
        public ArtWorksModel Artsit { get; set; }
        public int UserId { get; set;} 
        public UsersModel User { get; set; }

    }
}
