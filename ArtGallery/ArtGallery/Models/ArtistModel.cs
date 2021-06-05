using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.Models
{
    public class ArtistModel
    {
        [Key]
        public int ArtId { get; set; }
        public string ArtName { get; set; }
        public string ArtImg { get; set; }
        public string ArtBio { get; set; }

        //Relationship One-to-Many (Artist-to-Paintings)
        public List<PaintingModel> Paintings { get; set; }
    }
}
