using System;
using System.Collections.Generic;

namespace Crystal_circus.Models
{
    public class ShowModel
    {
        public int Id { get; set; }
        public string Time { get; set; }
        //nav
        public VenueModel Venue { get; set; }
        public int VenueId { get; set; }

        public List<ShowPerformerModel> ShowPerformer { get; set; }
    }
}
