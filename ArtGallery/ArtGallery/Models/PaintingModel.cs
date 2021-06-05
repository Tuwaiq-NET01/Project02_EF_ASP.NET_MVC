using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ArtGallery.Models
{
    public class PaintingModel
    {
        [Key]
        public int PntId { get; set; }
        public string PntName { get; set; }
        public string PntImg { get; set; }
        public string PntOverview { get; set; }
        public double PntPrice { get; set; }

        // RelationShip: One-To-One(Gallery-to-Painting)
        public GalleryModel Gallery { get; set; }
        //Fk
        public int GalleryId { get; set; }

        //Relationship : One-To-Many: (Artist-to-Paintings)
        public ArtistModel Artist { get; set; }

        //FK
        public int ArtistId { get; set; }


        //Relationship : One-To-Many: (Buyer-to-Paintings)
        public BuyerModel Buyer { get; set; }

        //FK
        public int BuyerId { get; set; }

    }
}





