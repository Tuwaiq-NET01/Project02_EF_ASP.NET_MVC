using System;
using System.Collections.Generic;

namespace Crystal_circus.Models
{
    public class PerformerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Image { get; set; }

        public List<ShowPerformerModel> ShowPerformer { get; set; }
    }
}
