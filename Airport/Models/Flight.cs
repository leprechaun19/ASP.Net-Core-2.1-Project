using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Departure Date")]
        public DateTime DepartureDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Destination Date")]
        public DateTime DestinationDate { get; set; }

 
        public Guid AirplaneID { get; set; }
	public Airplane Airplane { get; set; }

	public Guid AirportFromID { get; set; }
        public Airportt AirportFrom { get; set; }

        [Display(Name ="To")]
        public string AirportTo { get; set; }

	public Guid TimeTableID { get; set; }
        public TimeTable TimeTable { get; set; }


    }
}
