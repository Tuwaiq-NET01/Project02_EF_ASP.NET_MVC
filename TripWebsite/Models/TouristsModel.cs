using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TripWebsite.Models
{
    public class TouristsModel
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(10)]
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        //RelationShip
        public List<ScheduledToursModel> ScheduledTours { get; set; }

    }
}
