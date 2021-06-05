using System;
namespace Crystal_circus.Models
{
    public class ShowPerformerModel
    {
        public int Id { get; set; }

        public ShowModel Show { get; set; }
        public int ShowId { get; set; }

        public PerformerModel Performer { get; set; }
        public int PerformerId { get; set; }
    }
}
