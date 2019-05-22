using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Airline
    {
        public Airline()
        {
        }

        [Key]
        public Guid AirlineID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Airline Full Name")]
        public string AirlineFullName { get; set; }
    }
}
