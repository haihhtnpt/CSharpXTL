using System.Runtime.CompilerServices;
using System;
using System.ComponentModel.DataAnnotations;

namespace CSprj
{
    public class Ticket
    {
        public Ticket(){

        }
        public Ticket(string name, string address, string cardNo, DateTime birth, TicketType type)
        {
            Name = name;
            Address = address;
            CardNo = cardNo;
            _birth = birth;
            Type = type;
        }
        private DateTime _birth;
        [Required()]
        public DateTime Birth { get => _birth; } 
        [Required()]
        public string Name { get; set; }
        [Required()]
        public string Address { get; set; }
        [Required()]
        public string CardNo { get; set; }
        [Required()]
        public TicketType Type { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Range(1 , 150 , ErrorMessage = "Age is not valid")]
        public int Age
        {
            get => _birth.Year == DateTime.Now.Year ? 1 : DateTime.Now.Year - _birth.Year;
        }
        public decimal Payment
        {
            get
            {
                if (Age >= 7)
                {
                    return Type == TicketType.Normal ? 3000000 : 4000000;
                }
                return Type == TicketType.Normal ? 700000 : 1500000;
            }
        }
    }
}