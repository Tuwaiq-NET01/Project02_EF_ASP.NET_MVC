using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TripWebsite.Models
{
    public class TourguidersModel
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public string Img { get; set; }
        [MaxLength(10)]
        public int PhoneNumber { get; set; }

        //navication proprties
        public int DestinationId { get; set; }
        //FK
        public DestinationsModel Destination { get; set; }

        //RelationShip
        public List<ScheduledToursModel> ScheduledTours { get; set; }


    }
}
