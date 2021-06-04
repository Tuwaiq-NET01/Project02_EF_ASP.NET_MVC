using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerReview.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string GameName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Genre { get; set; }


        //Navigation Propoertiespublic 
        public int CompanyId { get; set; } //FK
        public Company Company{ get; set;}




    }
}
