using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Flight
    {
        public Flight()
        {
        }

        [Key]
        public Guid FligthID { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Departure Date (dd.MM.yyyy hh:mm)")]
        public DateTime DepartureDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Destination Date (dd.MM.yyyy hh:mm)")]
        public DateTime DestinationDate { get; set; }

        public Guid AirplaneID { get; set; }
        [ForeignKey("AirplaneID")]
	    public Airplane Airplane { get; set; }

	    public Guid AirportFromAirportID { get; set; }
        [ForeignKey("AirportFromAirportID")]
        public Airportt AirportFrom { get; set; }

        [Display(Name = "To")]
        public Guid AirportToAirportID { get; set; }
        public Airportt AirportTo { get; set; }

        public Guid TimeTableID { get; set; }
        [ForeignKey("TimeTableID")]
        public TimeTable TimeTable { get; set; }

        [Required]
        public double PriceFlight { get; set; }
    }
}
