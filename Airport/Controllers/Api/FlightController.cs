using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data;
using Airport.Models;
using Airport.Models.Новая_папка;
using Microsoft.AspNetCore.Mvc;


namespace Airport.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Flight")]
    public class FlightController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FlightController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Flight
        [HttpGet]
        public IActionResult GetFlight()
        {
            List<FlightDataTableModel> flights = new List<FlightDataTableModel>();

            foreach(Flight f in _context.Flights.ToList())
            {
                FlightDataTableModel fl = new FlightDataTableModel();
                fl.FligthID = f.FligthID;
                fl.DepartureDate = f.DepartureDate;
                fl.DestinationDate = f.DestinationDate;
                fl.AirplaneType = _context.Airplanes.FirstOrDefault(x => x.AirplaneID.Equals(f.AirplaneID)).AirplaneType;

                Airportt airportFrom = _context.Airportts.FirstOrDefault(x => x.AirportID.Equals(f.AirportFromAirportID));
                Airportt airportTo = _context.Airportts.FirstOrDefault(x => x.AirportID.Equals(f.AirportToAirportID));
                fl.AirportFrom = airportFrom.AirportName + "( " + airportFrom.CountryName + ", " + airportFrom.CityName + ")" ;
                fl.AirportTo = airportTo.AirportName + "( " + airportTo.CountryName + ", " + airportTo.CityName + ")";
                fl.FlightTime = _context.TimeTables.FirstOrDefault(x => x.TimeTableID.Equals(f.TimeTableID)).FlightTime;
                fl.PriceFlight = f.PriceFlight;

                flights.Add(fl);
            }
            return Json(new { data = flights });
        }


        // POST: api/Flight
        [HttpPost]
        public async Task<IActionResult> PostFlight([FromBody] Flight flight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Airportt airport = _context.Airportts.SingleOrDefault(x => x.AirportID == flight.AirportToAirportID);
                flight.AirportToAirportID = airport.AirportID;
                if (flight.FligthID == Guid.Empty)
                {
                    flight.FligthID = Guid.NewGuid();
                    _context.Flights.Add(flight);

                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Add new data success." });
                }
                else
                {
                    _context.Update(flight);

                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Edit data success." });
                }
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }

        }

        // DELETE: api/Flight/....
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlight([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var flight = _context.Flights.SingleOrDefault(m => m.FligthID == id);
                if (flight == null)
                {
                    return NotFound();
                }

                _context.Flights.Remove(flight);
                await _context.SaveChangesAsync();

                return Json(new { success = true, message = "Delete success." });
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }


        }

        private bool FlightExists(Guid id)
        {
            return _context.Flights.Any(e => e.FligthID == id);
        }
    }
}
