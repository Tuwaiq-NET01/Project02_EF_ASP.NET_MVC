using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewcastleUniversity.Models
{
    public class RoomModel
    {
        public int Id { get; set; }
        public int RoomNum { get; set; }

        //FOR TEST one to one
        public StudentModel Student { get; set; }
        public int StudentId { get; set; }//FK

    }
}

