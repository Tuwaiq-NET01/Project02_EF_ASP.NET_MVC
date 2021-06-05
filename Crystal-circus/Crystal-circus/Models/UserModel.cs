using System;
using System.Collections.Generic;

namespace Crystal_circus.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        //nav
        public CreditcardModel Creditcard { get; set; }
        //fk
        public int CreditcardId { get; set; }
        //
        public List<TicketModel> Tickets { get; set; }
    }
}
