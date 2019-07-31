using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Airport.Models
{
    [DataContract]
    public class Airline
    {
        public Airline()
        {
        }

        [DataMember]
        [Key]
        public Guid AirlineID { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        [Display(Name = "Airline Full Name")]
        public string AirlineFullName { get; set; }
    }
}
