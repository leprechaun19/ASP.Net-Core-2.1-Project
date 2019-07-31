using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models.Новая_папка
{
    public class FlightDataTableModel
    {
        public Guid FligthID { get; set; }
        public DateTime DepartureDate { get; set; }

        public DateTime DestinationDate { get; set; }

        public string AirplaneType { get; set; }

        public string AirportFrom { get; set; }

        public string AirportTo { get; set; }
        public string FlightTime { get; set; }
        public double PriceFlight { get; set; }
    }
}
