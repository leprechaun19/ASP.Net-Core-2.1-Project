using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Airportt
    {
        public Airportt()
        {
        }

        [Key]
        public Guid AirportID { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Airport Name")]
        public string AirportName { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "City Name")]
        public string CityName { get; set; }
    }
}
