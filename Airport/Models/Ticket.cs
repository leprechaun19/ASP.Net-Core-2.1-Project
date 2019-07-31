using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airport.Models
{
    public class Ticket
    {

        public Ticket()
        {
        }

        [Key]
        public Guid TicketID { get; set; }

        [Required]
        public Guid FlightFligthID { get; set; }
        [ForeignKey("FlightFligthID")]
        public Flight Flight { get; set; }

        [Required]
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public int Seat { get; set; }

        [Required]
        public double Price { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

    }
}
