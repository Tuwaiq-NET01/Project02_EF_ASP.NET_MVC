using System;
using System.Collections.Generic;

namespace Crystal_circus.Models
{
    public class VenueModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        //
        public List<ShowModel> Shows { get; set; }
    }
}
