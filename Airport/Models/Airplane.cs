﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Airport.Models
{
    public class Airplane
    {
        public Airplane()
        {
        }

        [Key]
        public Guid AirplaneID { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Airplane Type")]
        public string AirplaneType { get; set; }

        [Required]
        [Range(0, 200)]
        [Display(Name = "Number of places")]
        public string NumPlaces { get; set; }

        public Guid AirlineID { get; set; }
        public Airline Airline { get; set; }
    }
}
