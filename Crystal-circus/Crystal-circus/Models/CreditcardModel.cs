using System;
namespace Crystal_circus.Models
{
    public class CreditcardModel
    {
        public int Id { get; set; }
        public int CardNumber { get; set; }
        public string HolderName { get; set; }
        public string Date { get; set; }
        public int CVCNumber { get; set; }
    }
}
