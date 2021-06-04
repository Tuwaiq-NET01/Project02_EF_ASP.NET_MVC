using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirportSystems.Models
{
    public class PassengerModel
    {
        [Key]
        public int Passenger_ID { get; set; }
        public int Passport_NO { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }

        //Relationship:One-To-Many Trips -----<-Passengers
        public int TripID { get; set; }
        public TripModel Trip { get; set; }
    }
}
