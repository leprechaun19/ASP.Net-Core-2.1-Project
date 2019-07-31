using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data;
using Airport.Models;
using Airport.Models.TicketViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airport.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Ticket")]
    public class TicketController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TicketController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Ticket
        [HttpGet]
        public IActionResult GetTickets()
        {
            List<TicketDataTableModel> tickets = new List<TicketDataTableModel>();

            foreach (Ticket t in _context.Ticket.ToList())
            {
                TicketDataTableModel model = new TicketDataTableModel();
                Flight f = _context.Flights.FirstOrDefault(x => x.FligthID.Equals(t.FlightFligthID));
                Airportt airportFrom = _context.Airportts.FirstOrDefault(x => x.AirportID.Equals(f.AirportFromAirportID));
                Airportt airportTo = _context.Airportts.FirstOrDefault(x => x.AirportID.Equals(f.AirportToAirportID));

                model.TicketID = t.TicketID;
                model.Seat = t.Seat;
                model.Price = t.Price;
                model.OrderDate = t.OrderDate;
                model.User = _context.User.FirstOrDefault(x => x.UserId.Equals(t.UserId));   
                model.AirportFrom = airportFrom.AirportName + "( " + airportFrom.CountryName + ", " + airportFrom.CityName + ")";
                model.AirportTo = airportTo.AirportName + "( " + airportTo.CountryName + ", " + airportTo.CityName + ")";
                model.DepartureDate = f.DepartureDate;

                tickets.Add(model);
            }
            return Json(new { data = tickets });
        }


        // POST: api/Ticket
        [HttpPost]
        public async Task<IActionResult> PostTicket([FromBody] Ticket ticket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                ticket.Price = 2 * _context.Flights.FirstOrDefault(f => f.FligthID.Equals(ticket.FlightFligthID)).PriceFlight;
                if (ticket.TicketID == Guid.Empty)
                {
                    ticket.TicketID = Guid.NewGuid();
                    ticket.OrderDate = DateTime.Today;
                    _context.Ticket.Add(ticket);

                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Add new data success." });
                }
                else
                {
                    _context.Update(ticket);

                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Edit data success." });
                }
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }

        }

        // DELETE: api/Ticket/....
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var ticket = _context.Ticket.SingleOrDefault(m => m.TicketID == id);
                if (ticket == null)
                {
                    return NotFound();
                }

                _context.Ticket.Remove(ticket);
                await _context.SaveChangesAsync();

                return Json(new { success = true, message = "Delete success." });
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }


        }

        private bool TicketExists(Guid id)
        {
            return _context.Ticket.Any(e => e.TicketID == id);
        }
    }
}
