using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Data;
using Airport.Models;
using Microsoft.AspNetCore.Authorization;
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
            return Json(new { data = _context.Flights.ToList() });
        }


        // POST: api/User
        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] Flight flight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {

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
