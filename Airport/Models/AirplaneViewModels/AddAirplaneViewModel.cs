using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models.AirplaneViewModels
{
    public class AddAirplaneViewModel
    {
        public Guid AirlineID { get; set; }

        public string AirplaneType { get; set; }

        public string NumPlaces { get; set; }

        public Guid AirplaneID { get; set; }
    }
}
