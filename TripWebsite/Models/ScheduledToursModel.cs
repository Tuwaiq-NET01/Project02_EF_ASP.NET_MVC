using System;
using System.ComponentModel.DataAnnotations;

namespace TripWebsite.Models
{
    public class ScheduledToursModel
    {
        public int Id { get; set; }

        //FK
        public int DestinationId { get; set; }
        [MaxLength(20)]
        public string DestinationName { get; set; }
        [MaxLength(200)]
        public string DestinationBriefInformation { get; set; }
        public string DestinationImg { get; set; }
        public string DestinationDate { get; set; }
        public decimal DestinationPrice { get; set; }
        
        //navication proprties
        public DestinationsModel Destination { get; set; }


        //navication proprties
        public int TourguiderId { get; set; }
        //FK
        public TourguidersModel Tourguider { get; set; }


        //navication proprties
        public int TouristId { get; set; }
        //FK
        public TouristsModel Tourist { get; set; }
    }
}
