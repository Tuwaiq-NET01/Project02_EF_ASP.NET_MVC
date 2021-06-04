using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirportSystems.Models
{
    public class PlaneModel
    {
        [Key]
        public int Plane_ID { get; set; }
        public int Capacity { get; set; }
        public string Plane_Name { get; set; }
        public string Plane_Type { get; set; }
        //Relationship:One-To-Many Airports -----<-Planes
        //FK
        public int Airport_ID { get; set; }
        public AirportModel Airports { get; set; }

        //Relationship:One-To-Many Plane -----<-Trip
        public List<TripModel> Trip { get; set; }



    }
}
