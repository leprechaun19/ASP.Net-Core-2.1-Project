using Airport.Data;
using Airport.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Airport")]
    public class AirporttController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AirporttController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Airport
        [HttpGet]
        public IActionResult GetAirports()
        {
            return Json(new { data = _context.Airportts.ToList() });
        }


        // POST: api/Airport
        [HttpPost]
        public async Task<IActionResult> PostAirport([FromBody] Airportt airportt)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {

                if (airportt.AirportID== Guid.Empty)
                {
                    airportt.AirportID = Guid.NewGuid();
                    _context.Airportts.Add(airportt);

                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Add new data success." });
                }
                else
                {
                    _context.Update(airportt);

                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Edit data success." });
                }
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }

        }

        // DELETE: api/Airport/....
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAirport([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var airport = _context.Airportts.SingleOrDefault(m => m.AirportID== id);
                if (airport == null)
                {
                    return NotFound();
                }

                _context.Airportts.Remove(airport);
                await _context.SaveChangesAsync();

                return Json(new { success = true, message = "Delete success." });
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }


        }

        private bool AirportExists(Guid id)
        {
            return _context.Airportts.Any(e => e.AirportID== id);
        }
    }
}
