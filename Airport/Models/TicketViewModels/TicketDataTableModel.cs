using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models.TicketViewModels
{
    public class TicketDataTableModel
    {

        public Guid TicketID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string AirportFrom { get; set; }

        public string AirportTo { get; set; }

        public User User { get; set; }

        public int Seat { get; set; }

        public double Price { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
