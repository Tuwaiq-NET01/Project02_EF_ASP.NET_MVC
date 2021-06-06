using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TripWebsite.Models
{
    public class DestinationsModel
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string BriefInformation { get; set; }
        public string Img { get; set; }
        public string Date { get; set; }
        public decimal Price { get; set; }

        //navication proprties
        public ScheduledToursModel ScheduledTour { get; set; }


        //RelationShip
        public List<TourguidersModel> Tourguiders { get; set; }
    }
}

