using System;
using System.Collections.Generic;
using System.Linq;
using Airport.Data;
using Airport.Models;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    public class FlightController : Controller
    {
        private readonly ApplicationDbContext _DBcontext;

        public FlightController(ApplicationDbContext context)
        {
            _DBcontext = context;
        }

        public IActionResult Index()
        {
            IList<Flight> users = _DBcontext.Flights.ToList();
            return View(users);
        }

        public IActionResult AddEdit(Guid id)
        {
            ViewBag.TimeTables = _DBcontext.TimeTables.ToList();
            ViewBag.Airports = _DBcontext.Airportts.ToList();
            ViewBag.Airplanes = _DBcontext.Airplanes.ToList();
            if (id != Guid.Empty)
            {       
                return View(_DBcontext.Flights.Where(x => x.FligthID.Equals(id)).FirstOrDefault());
            }
            else {
                Flight flight = new Flight();
                return View(flight);
            }          
        }
    }
}
