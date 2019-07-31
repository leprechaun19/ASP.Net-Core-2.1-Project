using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data;
using Airport.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airport.Controllers
{
    public class TicketController : Controller
    {

        private readonly ApplicationDbContext _DBcontext;

        public TicketController(ApplicationDbContext context)
        {
            _DBcontext = context;
        }

        public IActionResult Index()
        {
            IList<Ticket> users = _DBcontext.Ticket.ToList();
            return View(users);
        }

        public IActionResult AddEdit(Guid id)
        {
            List<Flight> flights = _DBcontext.Flights.ToList();
            foreach (Flight fl in flights)
            {
                fl.AirportFrom = _DBcontext.Airportts.FirstOrDefault(x => x.AirportID.Equals(fl.AirportFromAirportID));
                fl.AirportTo = _DBcontext.Airportts.FirstOrDefault(x => x.AirportID.Equals(fl.AirportToAirportID));
            }
            ViewBag.Flights = flights;
            ViewBag.Users = _DBcontext.User.ToList();
            if (id != Guid.Empty)
            {             
                return View(_DBcontext.Ticket.Where(x => x.TicketID.Equals(id)).FirstOrDefault());
            }
            else
            {
                Ticket ticket = new Ticket();
                return View(ticket);
            }
        }
    }
}
