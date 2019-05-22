using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            IList<Models.Flight> users = _DBcontext.Flights.ToList();
            return View(users);
        }

        public IActionResult AddEdit(Guid id)
        {
            ViewBag.Airports = _DBcontext.Airportts.ToList();
            if (id == Guid.Empty)
            {
                Flight flight = new Flight();
                return View(flight);
            }
            else
            {
                return View(_DBcontext.Flights.Where(x => x.FligthID.Equals(id)).FirstOrDefault());
            }

        }
    }
}
