using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Ticket
    {

        public Ticket()
        {
        }

        [Key]
        public Guid TicketID { get; set; }

	public Guid FlightID { get; set; }
        public Flight Flight { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int Seat { get; set; }

        [Required]
        public double Price { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }
    }
}
