using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models.FlightViewModels
{
    public class AddEditFlightViewModel
    {
        public Flight Flight { get; set; }

        public ICollection<Airportt> Airports { get; set; }

        public ICollection<Airline> Airlines { get; set; }
        public ICollection<TimeTable> TimaTables { get; set; }
    }
}
