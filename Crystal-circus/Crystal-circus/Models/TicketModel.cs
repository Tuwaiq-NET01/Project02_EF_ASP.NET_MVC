using System;
namespace Crystal_circus.Models
{
    public class TicketModel
    {
        public int Id { get; set; }

        //user 1:m ticket
        public UserModel User { get; set; }
        public int UserId { get; set; }
        //ticket 1:1 show
        public ShowModel Show { get; set; }
        public int ShowId { get; set; }
    }
}
